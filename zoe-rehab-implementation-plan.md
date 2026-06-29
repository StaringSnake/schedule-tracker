# Zoe Rehab Tracker — Implementation Plan

A learn-by-doing roadmap for building a full-stack app to track Zoe's IVDD recovery: training schedules, sessions, exercises, and notes — accessible from your phone.

## How we work together

- **You drive.** Each phase gives you a goal, the concepts to practice, and tasks — but you write the code.
- **I support.** Bring me your code for review, or your blocker when stuck. I explain the *why*, point you at the right concept, and only hand over full code for pure boilerplate or when you've genuinely hit a wall after trying.
- **One phase at a time.** Don't skip ahead. Each phase has a "Done when" checklist — when you can tick all boxes, you're ready for the next.
- **Commit at each checkpoint.** Treat every "Done when" as a git commit. You'll end up with a clean history to show.

## Stack

- **Backend:** ASP.NET Core Web API (C#)
- **ORM / DB:** EF Core + SQLite (dev) → PostgreSQL (deploy)
- **Frontend:** React + TypeScript + Vite
- **Phone access:** responsive layout + PWA (installs to home screen)
- **Hosting:** Azure App Service / Container Apps, or Render

---

## Phase 0 — Project setup ✅ (mostly done)

**Goal:** a solution that builds, under version control.

- [ ] Solution + Web API project scaffolded (done last session)
- [ ] `git init`, add a `.gitignore` (use `dotnet new gitignore`), first commit
- [ ] Add a `README.md` describing the project in one paragraph

**Done when:** repo builds with `dotnet build` and your first commit is in.

---

## Phase 1 — Data layer (your DB-management practice)

**Goal:** a real database with the correct relationships, created via EF Core migrations.

**Concepts to practice:** entity relationships (one-to-many, many-to-many via a join entity with payload), EF Core navigation properties & conventions, `DbContext`, code-first migrations.

**Your tasks:**
- [ ] Create the entity classes (we drafted these last session — type them out yourself, don't paste blindly; understand each navigation property)
- [ ] Create `AppDbContext` with a `DbSet` per entity
- [ ] Register the context in `Program.cs` with `UseSqlite`
- [ ] Run `dotnet ef migrations add InitialCreate` and inspect the generated migration — can you read what it's doing?
- [ ] Run `dotnet ef database update` and open the `.db` file (DB Browser for SQLite) to see your tables
- [ ] Write a small seed routine that inserts Zoe + a few exercises (Cavalletti, controlled leash walk, sit-to-stands)

**Questions to be able to answer before moving on:**
- Why does `SessionExercise` exist instead of a direct many-to-many?
- What did EF Core infer as foreign keys, and how?
- What happens to the migration if you change a model and add a second migration?

**Done when:** the DB exists with all tables/relationships, and seeded data is queryable.

---

## Phase 2 — API layer

**Goal:** REST endpoints for the core resources.

**Concepts to practice:** REST resource design, controllers vs. minimal APIs, **DTOs** (why you don't expose entities directly), model validation, async/await with EF Core, dependency injection.

**Your tasks:**
- [ ] Decide: controllers or minimal APIs (I'll help you weigh it — both are worth knowing)
- [ ] Build CRUD for `Schedules`, `Sessions`, `Notes`
- [ ] Introduce DTOs so your API contract is separate from your entities
- [ ] Add basic validation (e.g. a Note must have a body; pain level 0–10)
- [ ] Test every endpoint with the `.http` file or Swagger UI
- [ ] Enable CORS for your future frontend origin

**Questions to answer:**
- Why map entities to DTOs instead of returning them directly?
- What status code should a successful POST return, and what should it include?

**Done when:** you can create/read/update/delete a schedule and its sessions and notes through Swagger.

---

## Phase 3 — Frontend foundation

**Goal:** a running React + TS app that can talk to your API.

**Concepts to practice:** Vite project structure, TypeScript in React (props, typed API responses), client-side routing, a typed API client, environment config (API base URL).

**Your tasks:**
- [ ] Scaffold with `npm create vite@latest` (React + TS template)
- [ ] Set up routing (React Router): routes for schedules list, schedule detail, notes
- [ ] Write a small typed `api` module (fetch wrapper) — define TS types matching your DTOs
- [ ] Fetch and render the list of schedules from your real API
- [ ] Handle loading and error states

**Questions to answer:**
- How do your TS types stay in sync with your C# DTOs? (We'll discuss options.)
- Where should the API base URL live so dev and prod differ cleanly?

**Done when:** the app loads real schedule data from your backend in the browser.

---

## Phase 4 — Core features (the React practice)

**Goal:** the screens you'll actually use daily.

**Concepts to practice:** controlled forms, component composition, state management (start with `useState`/`useReducer`; we'll discuss whether you need more), optimistic vs. refetch updates, lists & keys.

**Your tasks:**
- [ ] View a schedule with its sessions and exercises
- [ ] Create / edit a schedule
- [ ] Mark a session complete
- [ ] Write and edit notes, with date + optional pain/mobility scores
- [ ] Reusable form components rather than copy-pasted forms

**Done when:** you can run Zoe's daily rehab entirely through the UI — no Swagger needed.

---

## Phase 5 — Make it phone-ready

**Goal:** feels like an app on your phone.

**Concepts to practice:** responsive layout (mobile-first CSS), touch-friendly controls, PWA manifest + service worker, installability.

**Your tasks:**
- [ ] Make the layout mobile-first (it's a phone app first, desktop second)
- [ ] Add a web app manifest (name, icons, theme color)
- [ ] Add a service worker so it installs and opens full-screen
- [ ] Test "Add to Home Screen" on your actual phone

**Done when:** Zoe Rehab sits on your home screen and opens like a native app.

---

## Phase 6 — Deploy

**Goal:** use it on the go, off your laptop.

**Concepts to practice:** swapping SQLite → PostgreSQL (Npgsql), running migrations against a real DB, environment variables/secrets, production CORS, hosting a .NET API + static frontend.

**Your tasks:**
- [ ] Add the Npgsql provider; create a new migration set against Postgres
- [ ] Move connection strings/secrets out of source
- [ ] Deploy the API (Azure App Service / Container Apps, or Render)
- [ ] Deploy the frontend (static host) pointing at the live API
- [ ] Lock CORS to your real frontend origin

**Done when:** you open the live URL on your phone and log a real session.

---

## Phase 7 — Stretch goals (pick what interests you)

- [ ] **Auth** — even simple, so it's not public (good interview talking point)
- [ ] **Photo attachments** on notes (Zoe's progress over time)
- [ ] **Progress charts** — pain/mobility trends, sessions completed per week
- [ ] **Reminders / push notifications** for scheduled sessions
- [ ] **Tests** — a few API integration tests (plays to your QA background)

---

## Concept checklist (what you'll have practiced by the end)

Relational data modeling · EF Core & migrations · REST API design · DTOs & validation · DI · async data access · React + TypeScript · routing · forms & state · responsive/PWA · Postgres · deployment · (optionally) auth, file uploads, charts, tests.

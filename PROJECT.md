# Schedule Tracker

## What this is
Simple weekly tracker and planner. Allows the user to create events in the calendar and track the progress. 

## Stack
- Backend: ASP.NET Core (.NET 10), EF Core, SQLite (dev) / PostgreSQL
- Frontend: React + TypeScript
- Tests: xUnit, Playwright

## Layout
| Path | What lives there |
|---|---|
| src/Api/ | ASP.NET Core API |
| src/Web/ | React frontend |
| tests/ | ... |

## Scope right now
In: backend vertical slices, rehab session tracking.
Out: auth, deployment, mobile.

## Conventions pointer
Skills are binding. Repo-specific deviations live in docs/adr/.
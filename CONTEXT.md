# Zoe Rehab Tracker

Tracks Zoe's IVDD rehab: the exercise programs she follows, the blocks of
exercise she actually does, and how each one went. Single dog, single user.

## Language

**Schedule**:
A rehab program covering a fixed span of time (e.g. "Week 3, July 9–15"). It is
a plan the user creates; it owns the concrete Sessions that make it up and may
be marked as repeating.
_Avoid_: Plan, program, routine, template

**Session**:
One block of rehab that happens at a point in time — a single sitting in which
Zoe performs a small set of exercises. It is the thing the user completes,
journals, and scores. Concrete and historical, not a reusable slot.
_Avoid_: Workout, slot, appointment

**Exercise**:
A *type* of rehab activity, defined once and reused across sessions (e.g.
"Cavalletti poles", "controlled leash walk", "sit-to-stands"). A catalogue entry
carrying no per-session detail of its own.
_Avoid_: Movement, activity, drill

**SessionExercise**:
The record of one Exercise being done within one Session, carrying how it was
performed that time (sets, reps, and/or duration). Exists because the same
Exercise is done in many Sessions with different amounts each time.
_Avoid_: Set, entry, rep

**Performance score**:
The user's rating of how well Zoe did an exercise block — how capable she was.
_Avoid_: Rating, grade

**Fatigue score**:
The user's rating of how tired Zoe was during or after a session.
_Avoid_: Tiredness, energy, exhaustion

**Journal note**:
Free-text annotation on a Session — the user's running observations
("A is going well, B seems too hard after A"). At most one per Session.
_Avoid_: Comment, log, remark

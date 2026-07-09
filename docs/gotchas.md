# Gotchas (this repo, persistent across runs)

Surprises about THIS repo that would trip the next agent: version-specific
breakage, library quirks, undocumented behavior of this codebase's stack.
Areas: BACKEND, FRONTEND, OPS, TESTING. Tooling/CLI/SDK gotchas that hold in
every repo are ENV and go to the harness's `runs/_gotchas.md` instead.

Not for: code bugs (docs/triage.md), skill deviations (ADR), flaky tests
(docs/quarantine.md).

Conductor appends and increments Hits; workers read their AREA's entries in
their prompt. Only André deletes, by promoting 3+ hit entries into
PROJECT.md's traps section (or a skill if the gotcha turns out general).

Entry format, append-only:

```
## [AREA] one-line title
Date: <date> | Run: <run folder> | Hits: 1
Symptom: what it looked like
Cause: what it actually was
Rule: what to do instead, one line
```

---
<!-- entries below -->

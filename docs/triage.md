# Triage backlog (this repo, persistent across runs)

Out-of-scope findings from all runs. Conductor appends after each run,
deduplicated against existing entries (duplicate = increment Hits, do not
re-append). André prunes: an entry leaves this file by becoming an issue,
being rejected with one line of why, or being fixed.

Entry format, append-only:

```
## [AREA] one-line title
Date: <date> | Run: <run folder> | Reported by: <agent> | Hits: 1
Finding: what was found, where (file/line if known)
Suggested action: issue / ignore / fix-in-passing-next-time
Status: OPEN
```

AREA: BACKEND, FRONTEND, OPS, TESTING. (ENV findings about tooling go to the harness gotcha log if they qualify as gotchas, otherwise here.)
Statuses André sets: OPEN, ISSUE #NN, REJECTED (<why>), FIXED (<run>).
Conductor never sets a status other than OPEN.

---
<!-- entries below -->

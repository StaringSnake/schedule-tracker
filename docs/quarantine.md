# Test quarantine registry (persistent, cross-run)

Every quarantined test lives here or the quarantine did not happen. The ops
tripwire "quarantine, never retry" is only honest if this file exists: an
unrecorded quarantine is a silently skipped test forever.

Rules:

- Whoever quarantines (implementer-ops, test-engineer) adds the entry in the
  same change that quarantines, and states the entry in their report. A
  quarantine without a registry entry is an automatic REVISE.
- Quarantined tests are excluded by category/annotation, never deleted.
- acceptance-verifier treats a quarantined test as NOT VERIFIABLE for any
  acceptance criterion that depends on it; that blocks, by its own rules.
  Quarantine is therefore never a way to get a red criterion to pass.
- André reviews this file when it has 3+ OPEN entries or any entry older
  than 30 days: fix it or delete the test, no third state.

Entry format:

```
## <FullyQualified.TestName>
Date: <date> | Run: <run folder> | Quarantined by: <agent>
Symptom: what the flake looks like (timing, ordering, env)
Suspected cause: one line, "unknown" is acceptable
Excluded via: <category/annotation/config used>
Status: OPEN
```

Statuses André sets: OPEN, FIXED (<run/PR>), DELETED (<why>).

---
<!-- entries below -->

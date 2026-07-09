---
name: Pipeline issue
about: Issue format used by the planner (github-issue-breakdown skill)
title: '<area>: <imperative summary>'
labels: ''
---

<!-- Format per github-issue-breakdown. Title example:
     weight-logs: add record endpoint with duplicate rejection
     Labels: feature/bug/chore + area label + migration/security/adr-required
     when flagged. -->

## Goal

One or two sentences.

## Spec reference

Feature spec: <path>. Covers acceptance criteria: #N, #N.

## Tasks

- [ ] concrete step
- [ ] concrete step
- [ ] tests per dotnet-testing skill

## Acceptance criteria

Copied verbatim from the spec (only the ones this issue covers).

## Dependencies

Blocked by: #NN / none. Parallelizable with: #NN.

## Flags

DESTRUCTIVE migration? Security-relevant? ADR required? (state or "none")

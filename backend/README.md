# DUA Backend Module

This folder contains the backend skeleton for DUA Streamliner following a modular monolith architecture.

## Scope
- `src/DUA.API`: REST API over HTTPS with OpenAPI and health endpoint placeholders.
- `src/DUA.Application`: Use-case orchestration, interfaces, DTOs, validators, and mappers.
- `src/DUA.Domain`: Core domain entities, value objects, enums, rules, and domain events placeholders.
- `src/DUA.Infrastructure`: AWS-oriented adapters and integrations (S3, SQS, Secrets Manager, observability placeholders).
- `src/DUA.Workers`: Background worker bootstrap and queue-consumer placeholders.

## Platform Targets
- Runtime: .NET 10 / C# 14
- Contract: OpenAPI
- Async model: Queue + worker
- Cloud target: AWS (S3, SQS, Secrets Manager, CloudWatch, OpenTelemetry)
- CI/CD: GitHub Actions (to be defined)
- IaC: Terraform under `terraform/environments/*`

## Status
Skeleton only (no business logic), ready for iterative implementation.

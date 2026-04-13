# DUA Streamliner Backend

Backend skeleton module for DUA Streamliner using a **modular monolith** architecture.

## Scope
- `src/DUA.API`: REST API over HTTPS, OpenAPI contract, middleware, and health endpoints.
- `src/DUA.Application`: application contracts, DTOs, validators, mappers, and use-case placeholders.
- `src/DUA.Domain`: domain entities, value objects, events, and rules placeholders.
- `src/DUA.Infrastructure`: persistence and external adapter placeholders (S3, SQS, Secrets Manager, observability).
- `src/DUA.Workers`: background workers for queue consumption and asynchronous processing.

## Platform targets
- **Runtime**: .NET 10 / C# 14 (configured as preview language features).
- **Hosting target**: AWS.
- **Object storage**: Amazon S3.
- **Queueing**: Amazon SQS.
- **Secrets**: AWS Secrets Manager.
- **Observability**: CloudWatch + OpenTelemetry.
- **IaC**: Terraform.
- **CI/CD**: GitHub Actions.

## Notes
This module currently contains only compile-safe placeholders and bootstrapping code. Business logic is intentionally not implemented.

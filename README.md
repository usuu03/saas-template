# Multi-Tenant SaaS Backend Boilerplate

A production-ready, script-first backend template for building **multi-tenant SaaS applications** with authentication, role-based access control (RBAC), subscription billing, and cloud-ready DevOps.

This project is designed with **CQRS**, **Clean Architecture**, and **SQL-first database migrations** — making it easy to extend into a real SaaS product without redoing the core infrastructure.

---

## 🚀 Features

- **Multi-Tenancy**
  - Row-level tenancy with `tenant_id` on all entities
  - Per-tenant RBAC (Owner / Admin / Member)

- **Authentication & Authorization**
  - JWT access + refresh tokens
  - Refresh token rotation with Redis blacklist
  - Policy-based role enforcement

- **Subscription Billing**
  - Stripe Checkout & Customer Portal
  - Webhook-based subscription lifecycle
  - Middleware to enforce plan limits

- **Script-First Database**
  - Versioned SQL migrations per domain
  - Managed via DbUp/Flyway
  - Seed scripts for dev/staging

- **Architecture**
  - Clean Architecture + CQRS (MediatR)
  - `Domain` → `Application` → `Persistence` → `Infrastructure` → `Api`
  - Isolation of domain logic from infrastructure

- **DevOps Ready**
  - Docker & docker-compose for local development
  - GitHub Actions CI/CD
  - Terraform IaC for cloud deployment
  - Observability with OpenTelemetry

---

## 📂 Project Structure

/Glevo.WebApi             # ASP.NET Core API (entrypoint, DI, middleware)
/Glevo.Application     # CQRS commands/queries, validation, interfaces
/Glevo.Domain          # Entities, value objects, domain events
/Glevo.Database       # DB layer, SQL runner, repositories
/Glevo.Infrastructure  # External services: Stripe, Email, Cache, Secrets


---

## 🛠 Tech Stack

- **Backend:** .NET 9, ASP.NET Core, MediatR, FluentValidation
- **Database:** PostgreSQL (SQL-first migrations), Redis (cache, token blacklist)
- **Billing:** Stripe API
- **Auth:** JWT (access + refresh)
- **Infrastructure:** Docker, Terraform
- **DevOps:** GitHub Actions, OpenTelemetry, Prometheus/Grafana or Azure Application Insights

---

## ⚡ Getting Started

### Prerequisites
- [.NET 9 SDK](https://dotnet.microsoft.com/)
- [Docker](https://www.docker.com/)
- [Stripe CLI](https://stripe.com/docs/stripe-cli) (for local webhook testing)

### Clone & Setup
```bash
# Clone repository
git clone https://github.com/<your-username>/multi-tenant-saas-backend.git
cd multi-tenant-saas-backend

# Create .env file (copy from .env.example)
cp .env.example .env

# Start local services
docker-compose up -d

# Apply database migrations
dotnet run --project Persistence.Migrations
````

### Run the API

```bash
dotnet run --project Glevo.WebApi
```

---

## 🗂 Branching Model

* `main` → always deployable (protected)
* `feature/...` → new features
* `fix/...` → bug fixes
* `chore/...` → tooling & maintenance
* `docs/...` → documentation changes

---

## 📜 License

MIT License – see [LICENSE](LICENSE) for details.

---

## 📌 Status

> **MVP Phase** – Building core multi-tenancy, authentication, and billing.
> Future features: Feature-flag enforcement per plan, email notifications, admin dashboard.

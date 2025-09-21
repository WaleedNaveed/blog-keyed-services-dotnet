# Keyed Services in .NET

This repository contains the source code for my blog post on [Keyed Services in .NET](https://wntech.hashnode.dev/keyed-services-dotnet-8).  
The project demonstrates how to resolve multiple implementations of the same interface using **.NET 8 Keyed Services**, without resorting to manual factories or complex DI hacks.

---

## Blog Post
Read the full article here: [Keyed Services in .NET – Cleanly Resolve Multiple Implementations](https://wntech.hashnode.dev/keyed-services-dotnet-8)  

---

## Features
- Demonstrates the problem of multiple service implementations (e.g., Stripe vs. PayPal).
- Shows how to register and resolve **Keyed Services** in .NET 8.
- Clean, minimal example focused on Dependency Injection best practices.
- Includes side-by-side comparison of **traditional DI** vs **keyed DI**.

---

## Tech Stack
- .NET 8
- C#
- Dependency Injection (built-in Microsoft.Extensions.DependencyInjection)

---

## Getting Started

1. **Clone the repo**
   ```bash
   git clone https://github.com/WaleedNaveed/blog-keyed-services-dotnet.git
   cd blog-keyed-services-dotnet
   ```

2. **Build the Project**
   ```bash
   dotnet build
   ```

3. **Run the Project**
   ```bash
   dotnet run
   ```

4. **Open Swagger UI**
   Once the app is running, navigate to
   ```bash
   https://localhost:7265/swagger/index.html
   ```

---

### Available API Endpoints

- **POST** `/api/Payment/oldway`  
  Uses the traditional factory approach.

- **POST** `/api/Payment/keyed`  
  Uses the new **.NET 8 Keyed Services** approach.

---

### Request Payload

Both endpoints expect a JSON payload:

```json
{
  "provider": "Stripe",
  "amount": 100
}
```

You can change "provider" to "PayPal" also.

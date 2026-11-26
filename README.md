# Design Patterns

> A high-level visual tour · **23 proven solutions · 3 categories**

`🟢 Creational` · `🔵 Structural` · `🟣 Behavioral`

---

## What is a design pattern?

*A named, reusable answer to a common problem.*

```mermaid
flowchart TD
    A["<b>Common problem</b><br/>e.g. too many if / else branches"] --> B["<b>Reusable pattern</b><br/>a named, proven design idea"]
    B --> C["<b>Clean solution</b><br/>flexible, testable, readable code"]
    style A fill:#3a2a22,stroke:#ff9e64,color:#ff9e64
    style B fill:#1f3340,stroke:#7dcfff,color:#7dcfff
    style C fill:#2a3524,stroke:#9ece6a,color:#9ece6a
```


# Problem → Pattern

*A quick cheat sheet.*

| Problem | Pattern |
|---|---|
| Need exactly one instance | 🟢 [Singleton](./Creational/Singleton/Singleton.md) |
| Complex object setup | 🟢 [Builder](./Creational/Builder/Builder.md) |
| Incompatible interfaces | 🔵 [Adapter](./Structural/Adapter/Adapter.md) |
| Add features without subclasses | 🔵 [Decorator](./Structural/Decorator/Decorator.md) |
| Too many if / else branches | 🟣 [Strategy](./Behavioral/Strategy/Strategy.md) |
| React to changes | 🟣 [Observer](./Behavioral/Observer/Observer.md) |

---

# 3 categories · 23 patterns

| 🟢 Creational | 🔵 Structural | 🟣 Behavioral |
|:---:|:---:|:---:|
| **Create** | **Compose** | **Communicate** |
| 5 patterns | 7 patterns | 11 patterns |

> ### Don't reinvent — reuse proven solutions.

---

**Not ready-made code: a proven design idea.**

<sub>Catalogued by the "Gang of Four" (1994)</sub>

---

➡️ Next: [Categories](Categories.md)

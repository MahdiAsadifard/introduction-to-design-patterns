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
# 3 categories · 23 patterns

| 🟢 Creational | 🔵 Structural | 🟣 Behavioral |
|:---:|:---:|:---:|
| **Create** | **Compose** | **Communicate** |
| 5 patterns | 7 patterns | 11 patterns |

> ### Don't reinvent — reuse proven solutions.
*Grouped by the kind of problem they solve.*

```mermaid
flowchart LR
    DP(["Design Patterns"]) --> C["<b>Creational</b><br/>How objects are created"]
    DP --> S["<b>Structural</b><br/>How objects are composed"]
    DP --> B["<b>Behavioral</b><br/>How objects communicate"]
    style DP fill:#1f3340,stroke:#7dcfff,color:#c0caf5
    style C fill:#2a3524,stroke:#9ece6a,color:#9ece6a
    style S fill:#232c47,stroke:#7aa2f7,color:#7aa2f7
    style B fill:#2f2747,stroke:#bb9af7,color:#bb9af7
```

| | Category | Focus |
|---|---|---|
| 🟢 | **Creational** | How objects are **created** |
| 🔵 | **Structural** | How objects are **composed** |
| 🟣 | **Behavioral** | How objects **communicate** |

---

## How many patterns?

*The Gang of Four catalogue.*

```mermaid
pie showData
    title 23 patterns
    "Creational" : 5
    "Structural" : 7
    "Behavioral" : 11
```

| Category | Count | |
|---|---:|---|
| 🟢 Creational | 5 | █████ |
| 🔵 Structural | 7 | ███████ |
| 🟣 Behavioral | 11 | ███████████ |
| **Total** | **23** | |

---

# Problem → Pattern

*A quick cheat sheet.*

| Problem | Pattern |
|---|---|
| Need exactly one instance | 🟢 [Singleton](./Creational/Singleton/README.md) |
| Complex object setup | 🟢 [Builder](./Creational/Builder/README.md) |
| Incompatible interfaces | 🔵 [Adapter](./Structural/Adapter/README.md) |
| Add features without subclasses | 🔵 [Decorator](./Structural/Decorator/README.md) |
| Too many if / else branches | 🟣 [Strategy](./Behavioral/Strategy/README.md) |
| React to changes | 🟣 [Observer](./Behavioral/Observer/README.md) |


**Not ready-made code: a proven design idea.**

<sub>Catalogued by the "Gang of Four" (1994)</sub>

---

➡️ Next: [Categories](Categories.md)

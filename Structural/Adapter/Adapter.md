<sub>// Structural · 1 of 3</sub>

# 🔵 Adapter

```mermaid
flowchart LR
    App["Your app<br/><small>expects Pay()</small>"] --> Ad["🔌 Adapter<br/><small>translates</small>"]
    Ad --> L["Legacy system<br/><small>has MakePayment()</small>"]
```

> 🔴 **PROBLEM**<br/>
> Interfaces don't match

> 🟢 **BENEFIT**<br/>
> Reuse old code without changing it

---

⬅️ [Structural](Structural.md) · ➡️ [Decorator](Decorator.md)

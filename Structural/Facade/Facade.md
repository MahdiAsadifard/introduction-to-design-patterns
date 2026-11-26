<sub>// Structural · 3 of 3</sub>

# 🔵 Facade

```mermaid
flowchart LR
    Cl[Client] -- "Play()" --> F[Facade]
    F --> V[Video]
    F --> A[Audio]
    F --> Co[Codec]
    F --> St[Storage]
```

> 🔴 **PROBLEM**<br/>
> A complex subsystem is hard to use

> 🟢 **BENEFIT**<br/>
> One simple entry point

---

⬅️ [Decorator](Decorator.md) · ➡️ [Behavioral](../Behavioral/Behavioral.md)

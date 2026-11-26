<sub>// Behavioral · 2 of 3</sub>

# 🟣 Observer

```mermaid
flowchart LR
    S["Subject<br/><small>state changed</small>"] -. notify .-> L1[Listener 1]
    S -. notify .-> L2[Listener 2]
    S -. notify .-> L3[Listener 3]
```

> 🔴 **PROBLEM**<br/>
> Tight coupling to know about changes

> 🟢 **BENEFIT**<br/>
> One change notifies many listeners

---

⬅️ [Strategy](Strategy.md) · ➡️ [Command](Command.md)

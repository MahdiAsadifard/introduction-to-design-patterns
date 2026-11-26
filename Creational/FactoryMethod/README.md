<sub>// Creational · 2 of 3</sub>

# 🟢 Factory Method

```mermaid
flowchart LR
    Cl[Client] --> F["Factory<br/><code>Create(type)</code>"]
    F --> Ci[● Circle]
    F --> Sq[■ Square]
    F --> Tr[▲ Triangle]
```

> 🔴 **PROBLEM**<br/>
> "new" scattered across the code

> 🟢 **BENEFIT**<br/>
> Object creation in one place
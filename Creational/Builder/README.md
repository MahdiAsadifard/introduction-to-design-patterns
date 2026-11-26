<sub>// Creational · 3 of 3</sub>

# 🟢 Builder

```mermaid
flowchart LR
    S1[1 Size] --> S2[2 Cheese] --> S3[3 Toppings] -- "Build()" --> P((Pizza))
```

> 🔴 **PROBLEM**<br/>
> Huge constructors, many parameters

> 🟢 **BENEFIT**<br/>
> Build complex objects step by step
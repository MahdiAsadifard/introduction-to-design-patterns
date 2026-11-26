<sub>// Creational · 1 of 3</sub>

# 🟢 Singleton

```mermaid
flowchart LR
    A[Client A] --> I((One shared<br/>instance))
    B[Client B] --> I
    C[Client C] --> I
```

> 🔴 **PROBLEM**<br/>
> Multiple copies of a shared resource

> 🟢 **BENEFIT**<br/>
> One controlled, shared instance
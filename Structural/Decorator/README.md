<sub>// Structural · 2 of 3</sub>

# 🔵 Decorator

```mermaid
flowchart TB
    subgraph Slack["+ Slack"]
        subgraph SMS["+ SMS"]
            E["Email (core)"]
        end
    end
```

> 🔴 **PROBLEM**<br/>
> Too many subclasses for combinations

> 🟢 **BENEFIT**<br/>
> Add features at runtime by wrapping
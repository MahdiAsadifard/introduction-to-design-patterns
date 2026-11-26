# 🟣 Reference
[Command Design pattern "refactoring.guru"](https://refactoring.guru/design-patterns/command)

# 🟣 Command

*Turn an action into an object, so you can run it, store it and undo it.*

```mermaid
flowchart LR
    Cl["🖱️ Client<br/><small>Button / CommandDemo</small>"] -- "Run(cmd)" --> Inv["<b>CommandHistory</b><br/><small>Invoker</small>"]
    Inv -- "Execute()" --> Cm["<b>AppendTextCommand</b><br/><small>Command</small>"]
    Cm -- "Text += value" --> R["<b>TextEditor</b><br/><small>Receiver</small>"]
    Inv -- "Push" --> H
    subgraph H["History · Stack"]
        direction TB
        h2["' World'  ← top"] --- h1["'Hello'"]
    end
    U(["↩ Undo()<br/><small>pops last command</small>"]) -.-> h2
    R --> T[/"Text: 'Hello World'"/]
```

> 🔴 **PROBLEM**<br/>
> Actions hard-wired to the UI

> 🟢 **BENEFIT**<br/>
> Queue, log and undo actions

## Roles

| Role | Class | Job |
|---|---|---|
| Command | `ICommand` / `AppendTextCommand` | Wraps one action with `Execute()` and `Undo()` |
| Receiver | `TextEditor` | Does the real work |
| Invoker | `CommandHistory` | Runs commands and keeps a stack for undo |
| Client | `CommandDemo` (or a button) | Creates commands and passes them to the invoker |

## How it runs
| Step | Call | History stack | Editor text |
|---|---|---|---|
| 1 | `Run("Hello")` | Hello | `Hello` |
| 2 | `Run(" World")` | Hello, **World** (top) | `Hello World` |
| 3 | `Undo()` | Hello | `Hello` |

## Watch the video

[![Watch the video](https://img.youtube.com/vi/a5vckWGkFFE/hqdefault.jpg)](https://www.youtube.com/shorts/a5vckWGkFFE)


---

⬅️ [Observer](Observer.md) · ➡️ [Summary](../Summary.md)

<sub>// Behavioral · 1 of 3</sub>

# 🟣 Strategy

```mermaid
flowchart TB
    C[Checkout] --> I{{"«IPayment»"}}
    I --> Ca[Card]
    I --> P[PayPal]
    I --> Cr[Crypto]
```

> 🔴 **PROBLEM**<br/>
> A growing if / else chain

> 🟢 **BENEFIT**<br/>
> Swap behavior without editing code

---

⬅️ [Behavioral](Behavioral.md) · ➡️ [Observer](Observer.md)

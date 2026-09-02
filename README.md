# How programs think

Practice for [CSD Core Lab Lesson 2](https://emscode82.github.io/lab/02-how-programs-think.html).

**Skill this proves:** you can name the inputs, write the steps in order, and code one decision (`if` / `else`) that changes the output.

## The problem

Orders of $50 or more ship free. Otherwise shipping is $5.00. Ask for the order total and print the shipping charge plus the amount due.

## Before you code

Open `docs/challenge.md`. Write the inputs, steps, and decision in plain language. Fill in the hand-check table. That write-up is part of done.

## Run in Visual Studio

1. Open `ShippingDecision.sln` (or `src/ShippingDecision/ShippingDecision.csproj`).
2. Press **F5** or **Debug → Start Debugging**.
3. Type an order total when asked. Try `49.99` and `50`.

Fill in the TODOs in `src/ShippingDecision/Program.cs`. The starter compiles as-is; it just does not apply the rule yet.

## Run from a terminal

```bash
dotnet run --project src/ShippingDecision
```

After you have tried it, run the reference solution:

```bash
dotnet run --project answers/ShippingDecision
```

## Done when

- `docs/challenge.md` lists inputs, numbered steps, and the if/else in your own words.
- `src/ShippingDecision/Program.cs` reads a total, applies the $50 rule, and prints shipping and amount due.
- A $49.99 order charges $5 shipping. A $50.00 order ships free.
- You compared your program to `answers/ShippingDecision/Program.cs` only after you ran yours.

## License

MIT

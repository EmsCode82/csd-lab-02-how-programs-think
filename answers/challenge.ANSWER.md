# ANSWER KEY — process write-up

Reference only. Fill in `docs/challenge.md` first.

## Inputs

- The order total (a dollar amount).

## Steps

1. Ask for the order total and store it.
2. If the total is 50 or more, shipping is 0; otherwise shipping is 5.00.
3. Add shipping to the order total.
4. Print the shipping charge and the amount due.

## Decisions

- If the order total is greater than or equal to 50
- Then shipping is $0.00 (free)
- Else shipping is $5.00

## Hand-check

| Order total | Shipping | Amount due |
| ----------- | -------- | ---------- |
| 49.99       | 5.00     | 54.99      |
| 50.00       | 0.00     | 50.00      |
| 72.40       | 0.00     | 72.40      |

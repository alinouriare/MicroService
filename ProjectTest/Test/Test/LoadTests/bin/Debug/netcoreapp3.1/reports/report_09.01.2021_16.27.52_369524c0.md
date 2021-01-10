# Scenario: `GET single person`

- Duration: `00:00:10`
- RPS: `197`
- Concurrent Copies: `1`

| __step__                 | __details__                                                             |
|--------------------------|-------------------------------------------------------------------------|
| name                     | `init`                                                                  |
| request count            | all = `1972`, OK = `1972`, failed = `0`                                 |
| response time            | RPS = `197`, min = `1`, mean = `4`, max = `2268`                        |
| response time percentile | 50% = `3`, 75% = `4`, 95% = `5`, StdDev = `51`                          |
| data transfer            | min = `0.080 Kb`, mean = `0.080 Kb`, max = `0.080 Kb`, all = `0.150 MB` |
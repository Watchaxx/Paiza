# 実行時間 20ms
n = int(input())
dp = [1]

for i in range(n + 1):
    dp.append(0)
    if 1 <= i:
        dp[i] += dp[i - 1]
    if 2 <= i:
        dp[i] += dp[i - 2]
print(dp[n])

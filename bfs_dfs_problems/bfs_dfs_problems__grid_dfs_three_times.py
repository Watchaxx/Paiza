# 実行時間 10ms
def dfs(i, y, x):
    if i == 3:
        print(y, x)
        return
    if 0 <= y - 1:
        dfs(i + 1, y - 1, x)
    if x + 1 < w:
        dfs(i + 1, y, x + 1)
    if y + 1 < h:
        dfs(i + 1, y + 1, x)
    if 0 <= x - 1:
        dfs(i + 1, y, x - 1)
    return


h, w, y, x = list(map(int, input().split()))
dfs(0, y, x)

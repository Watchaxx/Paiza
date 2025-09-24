# 実行時間 10ms
from collections import deque

def main():
    h, w = list(map(int, input().split()))
    sy, sx = list(map(int, input().split()))
    gy, gx = list(map(int, input().split()))
    dx = [0, 0, -1, 1]
    dy = [-1, 1, 0, 0]
    g = [list(input()) for _ in [0] * h]
    q = deque()

    g[sy][sx] = "*"
    q.append((sy, sx))
    while 0 < len(q):
        t = q.popleft()

        for i in range(4):
            x = t[1] + dx[i]
            y = t[0] + dy[i]
            if x == gx and y == gy:
                return True
            if 0 <= x < w and 0 <= y < h and g[y][x] == ".":
                g[y][x] = "*"
                q.append((y, x))
    return False

print("Yes" if main() else "No")

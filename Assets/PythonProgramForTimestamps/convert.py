with open("Timeline 1.edl", "r") as file:
    time_arr = [line.split("C")[-1].replace("\n", "").strip().split(" ")[0] for line in file.readlines() if line[0].isdigit()]
    
    with open("output.txt", "a") as outfile:
        for idx, ts in enumerate(time_arr):
            ts_arr = ts.split(":")
            ts_arr[-1] = str(int(ts_arr[-1]) * 2)
            hr,mn,sc,ms = map(int, ts_arr)
            n = f"{3600*int(hr)+int(mn)*60+int(sc)}.{int(ms)}f"
            outfile.write(f"markerTimes[{idx}] = {n}; // {ts}\n")
        
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        try {
            BufferedWriter writer = new BufferedWriter(new FileWriter("output.txt"));
            BufferedReader reader = new BufferedReader(new FileReader("TimeStamps.txt"));
            List<String> list = new ArrayList<>();
            String s = reader.readLine();
            while(s != null) {
                list.add(s);
                s = reader.readLine();
            }
            int lineCounter = 0;
            int arrayCounter = 0;
            while(lineCounter < list.size() - 1) {
                String timeString = list.get(lineCounter).substring(32, 40);
                int minutes = Integer.parseInt(timeString.substring(0, 2));
                int seconds = Integer.parseInt(timeString.substring(3, 5));
                int milliseconds = Integer.parseInt(timeString.substring(6, 8));
                milliseconds *= 2;
                if (milliseconds > 99) {
                    milliseconds = 99;
                }
                float time = minutes * 60 + seconds + milliseconds / 100.0f;
                String formattedTime = String.format("%.2f", time);
                String color = extractColor(list.get(lineCounter + 1));
                if(color.equals("Red")) {
                    writer.write("timestamps[" + arrayCounter + "] = new TimeStampDS(jumpObject, " + formattedTime + "f, spawnPointsArray[6]); // " + timeString + "\n");
                }
                else if(color.equals("Green")) {
                    writer.write("timestamps[" + arrayCounter + "] = new TimeStampDS(doubleHitBoxPrefab, " + formattedTime + "f, spawnPointsArray[0]); // " + timeString + "\n");
                }
                else if(color.equals("Blue")) {
                    writer.write("timestamps[" + arrayCounter + "] = new TimeStampDS(singleHitBoxPrefab, " + formattedTime + "f, spawnPointsArray[0]); // " + timeString + "\n");
                }
                else if(color.equals("Pink")) {
                    writer.write("timestamps[" + arrayCounter + "] = new TimeStampDS(dodgeObject, " + formattedTime + "f, spawnPointsArray[0]); // " + timeString + "\n");
                }
                arrayCounter++;
                lineCounter += 3;
            }
            reader.close();
            writer.close();

        }
        catch (Exception e) {
            System.out.println("Code phat gyaaaaa");
        }
    }

    private static String extractColor(String str) {
        str = str.trim();
        int start = str.indexOf("ResolveColor") + "ResolveColor".length();
        int end = str.indexOf(" ", start);
        if (end == -1) {
            end = str.length();
        }
        return str.substring(start, end);
    }
}
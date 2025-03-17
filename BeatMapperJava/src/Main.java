import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;

public class Main {
    public static void main(String[] args) {
        int currentIndex = 0;
        try {
            BufferedReader reader = new BufferedReader(new FileReader("TimeStamps.txt"));
            BufferedWriter writer = new BufferedWriter(new FileWriter("output.txt"));
            String line;
            while((line = reader.readLine()) != null) {
                double time = extractTime(line);
                line = reader.readLine();
                char color = extractColor(line);
                String position = extractPosition(line);
                StringBuilder sb = new StringBuilder();
                sb.append("timestamps[" + currentIndex++ + "]" + " = new TimeStampDS(");
                String type = colorConverter(color);
                sb.append(type + ", " + time + ", ");
                String spawnPoint = positionConverter(position, color);
                sb.append(spawnPoint + ");\n");
                writer.write(sb.toString());
                reader.readLine();
            }
            reader.close();
            writer.close();
        }
        catch(Exception e) {
            System.out.println("Exception");
        }
    }

    public static String positionConverter(String s, char color) {
        if(s.equals("L2")) return "spawnPointsArray[0]";
        if(s.equals("R2")) return "spawnPointsArray[1]";
        if(s.equals("L1")) return "spawnPointsArray[2]";
        if(s.equals("R1")) return "spawnPointsArray[3]";
        if(s.equals("M1")) return "spawnPointsArray[4]";
        if(s.equals("M2")) return "spawnPointsArray[5]";
        if(color == 'R') return "spawnPointsArray[6]";
        return "";
    }

    public static String colorConverter(char c) {
        if(c == 'B')
            return "singleHitBoxPrefab";
        if(c == 'P')
            return "dodgeObject";
        if(c == 'G')
            return "doubleHitBoxPrefab";
        if(c == 'R')
            return "jumpObject";
        return "";
    }

    public static String extractPosition(String s) {
        int mStart = s.indexOf("|M:") + 3; // Find the start of the M value
        if (mStart == 2) return ""; // If "|M:" is not found, return empty string

        int mEnd = s.indexOf(" ", mStart); // Find the next space after "|M:"
        if (mEnd == -1) mEnd = s.length(); // Handle case if there's no space after M value

        return s.substring(mStart, mEnd); // Extract and return the M value
    }

    public static char extractColor(String s) {
        int colorStart = s.indexOf("|C:") + 15; // Find the start of the color name
        if (colorStart == 2) return 'B'; // If "|C:" is not found, return empty string

        int colorEnd = s.indexOf(" ", colorStart); // Find the next space after "|C:"
        if (colorEnd == -1) colorEnd = s.length(); // Handle case if there's no space after the color

        String color = s.substring(colorStart, colorEnd); // Extract full color name
        return color.charAt(0); // Return the first letter of the color
    }

    public static double extractTime(String s) {
        int minutes = Integer.parseInt(s.substring(32, 33));
        int seconds = Integer.parseInt(s.substring(35, 37));
        int milliseconds = Integer.parseInt(s.substring(38, 40));

        if(milliseconds == 50) milliseconds--;
        milliseconds *= 2;
        return ((milliseconds / 100d) + seconds + (minutes * 60));
    }

}
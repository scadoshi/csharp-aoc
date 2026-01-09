namespace CSharpAoc.Year2016.Day02;

using CSharpAoc.Common;

public class Part01
{
    public static string Run(Face[][] input)
    {
        return input
            .Aggregate(
                ("", Keypad.Standard()),
                ((string, Keypad) acc, Face[] instructions) =>
                {
                    var (code, keypad) = acc;
                    var newKeypad = instructions.Aggregate(
                        keypad,
                        (k, face) =>
                        {
                            k.MoveFinger(face, 1);
                            return k;
                        }
                    );
                    var key = newKeypad.Grid[newKeypad.Finger.Row, newKeypad.Finger.Col];
                    return (code + key, newKeypad);
                }
            )
            .Item1;
    }
}

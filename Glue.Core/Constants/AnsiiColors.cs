namespace Glue.Core.Constants;

public static class AnsiiColors {
    public enum Colors {
        Black,
        BrightBlack,
        Red,
        BrightRed,
        Green,
        BrightGreen,
        Yellow,
        BrightYellow,
        Blue,
        BrightBlue,
        Purple,
        BrightPurple,
        Cyan,
        BrightCyan,
        White,
        BrightWhite,
        Reset
    }

    public static string ToColorString(Colors color) {
        return color switch {
            Colors.Black => "\e[0;30m",
            Colors.BrightBlack => "\e[0;90m",
            Colors.Red => "\e[0;31m",
            Colors.BrightRed => "\e[0;91m",
            Colors.Green => "\e[0;32m",
            Colors.BrightGreen => "\e[0;92m",
            Colors.Yellow => "\e[0;33m",
            Colors.BrightYellow => "\e[0;93m",
            Colors.Blue => "\e[0;34m",
            Colors.BrightBlue => "\e[0;94m",
            Colors.Purple => "\e[0;35m",
            Colors.BrightPurple => "\e[0;95m",
            Colors.Cyan => "\e[0;36m",
            Colors.BrightCyan => "\e[0;96m",
            Colors.White => "\e[0;37m",
            Colors.BrightWhite => "\e[0;97m",
            Colors.Reset => "\e[0m",
            _ => ""
        };
    }

    public static string ToBoldColorString(Colors color) {
        return color switch {
            Colors.Black => "\e[1;30m",
            Colors.BrightBlack => "\e[1;90m",
            Colors.Red => "\e[1;31m",
            Colors.BrightRed => "\e[1;91m",
            Colors.Green => "\e[1;32m",
            Colors.BrightGreen => "\e[1;92m",
            Colors.Yellow => "\e[1;33m",
            Colors.BrightYellow => "\e[1;93m",
            Colors.Blue => "\e[1;34m",
            Colors.BrightBlue => "\e[1;94m",
            Colors.Purple => "\e[1;35m",
            Colors.BrightPurple => "\e[1;95m",
            Colors.Cyan => "\e[1;36m",
            Colors.BrightCyan => "\e[1;96m",
            Colors.White => "\e[1;37m",
            Colors.BrightWhite => "\e[1;97m",
            Colors.Reset => "\e[0m",
            _ => ""
        };
    }

    public static string ToUnderlineColorString(Colors color) {
        return color switch {
            Colors.Black => "\e[4;30m",
            Colors.BrightBlack => "\e[4;90m",
            Colors.Red => "\e[4;31m",
            Colors.BrightRed => "\e[4;91m",
            Colors.Green => "\e[4;32m",
            Colors.BrightGreen => "\e[4;92m",
            Colors.Yellow => "\e[4;33m",
            Colors.BrightYellow => "\e[4;93m",
            Colors.Blue => "\e[4;34m",
            Colors.BrightBlue => "\e[4;94m",
            Colors.Purple => "\e[4;35m",
            Colors.BrightPurple => "\e[4;95m",
            Colors.Cyan => "\e[4;36m",
            Colors.BrightCyan => "\e[4;96m",
            Colors.White => "\e[4;37m",
            Colors.BrightWhite => "\e[4;97m",
            Colors.Reset => "\e[0m",
            _ => ""
        };
    }

    public static string ToBackgroundColorString(Colors color) {
        return color switch {
            Colors.Black => "\e[40m",
            Colors.BrightBlack => "\e[100m",
            Colors.Red => "\e[41m",
            Colors.BrightRed => "\e[101m",
            Colors.Green => "\e[42m",
            Colors.BrightGreen => "\e[102m",
            Colors.Yellow => "\e[43m",
            Colors.BrightYellow => "\e[103m",
            Colors.Blue => "\e[44m",
            Colors.BrightBlue => "\e[104m",
            Colors.Purple => "\e[45m",
            Colors.BrightPurple => "\e[105m",
            Colors.Cyan => "\e[46m",
            Colors.BrightCyan => "\e[106m",
            Colors.White => "\e[47m",
            Colors.BrightWhite => "\e[107m",
            Colors.Reset => "\e[0m",
            _ => ""
        };
    }
}

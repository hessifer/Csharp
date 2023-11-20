var regularGradeCount = 5;
int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];
int[] beckyScores = [92, 91, 90, 91, 92, 92, 92];
int[] chrisScores = [84, 86, 88, 90, 92, 94, 96, 98];
int[] ericScores = [80, 90, 100, 80, 90, 100, 80, 90];
int[] gregorScores = [91, 91, 91, 91, 91, 91, 91];  

// Student and Scores Arrays 
string[] names = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"];
decimal[] scores = [calculateScore(sophiaScores, regularGradeCount), calculateScore(andrewScores, regularGradeCount), calculateScore(emmaScores, regularGradeCount), calculateScore(loganScores, regularGradeCount), calculateScore(beckyScores, regularGradeCount), calculateScore(chrisScores, regularGradeCount), calculateScore(ericScores, regularGradeCount), calculateScore(gregorScores, regularGradeCount)];

// display overall exam scores for each student
Console.WriteLine("Student\t\tScore\t\tGrade");
for (int i = 0; i < names.Length; i++) {
    Console.WriteLine($"{names[i]}\t\t{scores[i], 2}\t\t{getLetterGrade(scores[i])}");
}

static string getLetterGrade(decimal score) {
    if (score > 96) {
        return "A+";
    } else if (score > 92) {
        return "A";
    } else if (score > 89) {
        return "A-";
    } else if (score > 86) {
        return "B+";
    } else if (score > 82) {
        return "B";
    } else if (score > 79) {
        return "B-";
    } else if (score > 77) {
        return "C+";
    } else if (score > 72) {
        return "C";
    } else if (score > 69) {
        return "C-";
    } else if (score > 66) {
        return "D+";
    } else if (score > 62) {
        return "D";
    } else if (score > 59) {
        return "D-";
    } else {
        return "F";
    }
}

static decimal calculateScore(int[] scores, int regularGradeCount) {
    decimal regularAssignmentsSum = 0M;
    decimal extraCreditCount = scores.Length - regularGradeCount; 
    decimal extraCreditSum = 0M;

    if (extraCreditCount > 0) {
        // calculate regular assignments sum
        for (int i = 0; i < regularGradeCount; i++) {
            regularAssignmentsSum += (decimal) scores[i];
        }

        // calculate extra credit sum and apply 10%
        for (int i = 0; i < extraCreditCount; i++) {
            extraCreditSum += (decimal) scores[i + regularGradeCount] / 10; 
        }
        return (regularAssignmentsSum + extraCreditSum) / (decimal) regularGradeCount;
    }
    return (decimal) scores.Sum() / (decimal) scores.Length; 
}

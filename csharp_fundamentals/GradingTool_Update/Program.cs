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
//decimal[] scores = [calculateScore(sophiaScores, regularGradeCount), calculateScore(andrewScores, regularGradeCount), calculateScore(emmaScores, regularGradeCount), calculateScore(loganScores, regularGradeCount), calculateScore(beckyScores, regularGradeCount), calculateScore(chrisScores, regularGradeCount), calculateScore(ericScores, regularGradeCount), calculateScore(gregorScores, regularGradeCount)];

// display overall exam scores for each student
Console.WriteLine("Student\t\tExam Score\t\tOverall Grade\t\t\tExtra Credit");
/*for (int i = 0; i < names.Length; i++) {
    Console.WriteLine($"{names[i]}\t\t{scores[i], 2}\t\t{getLetterGrade(scores[i])}");
}
*/
Console.WriteLine($"{names[0]}\t\t{calculateExamScore(sophiaScores, regularGradeCount)}\t\t\t{calculateOverallScore(sophiaScores, regularGradeCount)}\t{getLetterGrade(calculateExamScore(sophiaScores, regularGradeCount))}\t\t\t{extraCredit(sophiaScores, regularGradeCount)} {calculateOverallScore(sophiaScores, regularGradeCount) - calculateExamScore(sophiaScores, regularGradeCount)} pts)");

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

// function to calculate exam score
static decimal calculateExamScore(int[] scores, int regularGradeCount) {
        decimal regularAssignmentsSum = 0M;

        for (int i = 0; i < regularGradeCount; i++) {
            regularAssignmentsSum += (decimal) scores[i];
        }
    return regularAssignmentsSum / (decimal) regularGradeCount; 
}

// function to calculate extra credit
static double extraCredit(int[] scores, int regularGradeCount) {
    int extraCreditCount = scores.Length - regularGradeCount; 
    double extraCreditSum = 0;

    if (extraCreditCount > 0) {
        // calculate extra credit sum and apply 10%
        for (int i = extraCreditCount; i > 0; i--) {
            extraCreditSum += (int) scores[(i + regularGradeCount) - 1]; 
        }
        return extraCreditSum / extraCreditCount; 
    }
    return 0.0;
}

// function to calculate the overall score
static decimal calculateOverallScore(int[] scores, int regularGradeCount) {
    int extraCreditAssignmentCount = scores.Length - regularGradeCount;
    decimal extraCreditPoints = 0M;
    decimal regularAssignmentsTotal = 0M;
    decimal results = 0M;

    if (extraCreditAssignmentCount > 0) {
        for (int i = 0; i < extraCreditAssignmentCount; i++) {
            extraCreditPoints += (decimal) scores[regularGradeCount + i] / 10;
        }
    }

    for (int i = 0; i < regularGradeCount; i++) {
        regularAssignmentsTotal += (decimal) scores[i];
    }

    results = (regularAssignmentsTotal + extraCreditPoints) / (decimal) regularGradeCount;
    return results;
}
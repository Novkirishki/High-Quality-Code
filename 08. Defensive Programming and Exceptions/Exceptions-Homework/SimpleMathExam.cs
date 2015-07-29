using System;

public class SimpleMathExam : Exam
{
    private int problemsSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get
        {
            return this.problemsSolved;
        }
        private set
        {
            if (value < 0 || value > 2)
            {
                throw new ArgumentOutOfRangeException("Problems must be between 0 and 2");
            }

            this.problemsSolved = value;
        }
    }

    public override ExamResult Check()
    {
        if (ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Good result: 1 task done.");
        }
        else // problemsSolved = 2
        {
            return new ExamResult(6, 2, 6, "Perfect result: everything done.");
        }
    }
}

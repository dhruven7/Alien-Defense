using System;

public interface IScoreUpdater
{
    void setSuccessor(IScoreUpdater successor);
    int incrementScore(String enemy);
}
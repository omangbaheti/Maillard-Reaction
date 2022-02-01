using UnityEngine;
using UnityEngine.Serialization;

[System.Serializable]
[CreateAssetMenu]
public class Card : ScriptableObject
{
    [SerializeField] private string cardName;
    [TextArea(4,4)]
    [SerializeField] private string conditionText;
    [SerializeField] private EffectType effectType;
    [SerializeField] private int requiredRatings = -1;
    [SerializeField] private int requiredRevenue = -1;
    [SerializeField] private int requiredCash = -1;
    [SerializeField] private int changeRatingsByPercent = -1;
    [SerializeField] private int changeRevenueByPercent = -1;
    
    //TODO: Link meta changes to deck manager components
    
    public int ChangeRatingsByPercent => changeRatingsByPercent;
    public int ChangeRevenueByPercent => changeRevenueByPercent;

    public bool HasRequiredRatings(int currentRating)
    {
        if (requiredRatings < 0) return true; // -1 implies it isn't a necessary condition, so it's ignored
        return currentRating >= requiredRatings;
    }

    public bool HasRequiredRevenue(int currentRevenue)
    {
        if (requiredRevenue < 0) return true; // -1 implies it isn't a necessary condition, so it's ignored
        return currentRevenue >= requiredRevenue;
    }
    
    public bool HasRequiredCash(int currentCash)
    {
        if (requiredCash < 0) return true; // -1 implies it isn't a necessary condition, so it's ignored
        return currentCash >= requiredCash;
    }
}

using MauiBlazor.UserContext.Enums;

namespace MauiBlazor.UserContext.Data
{
    public class Actions
    {
        public static List<EActions> GetListActions(EAccessLevel accessLevel)
        {
            var actions = new List<EActions>();
            switch (accessLevel)
            {
                case EAccessLevel.Client:
                    actions.Add(EActions.Action1);
                    actions.Add(EActions.Action2);
                    actions.Add(EActions.Action3);
                    actions.Add(EActions.Action4);
                    actions.Add(EActions.Action5);
                    break;

                case EAccessLevel.Administrator:
                    actions.Add(EActions.Action6);
                    actions.Add(EActions.Action7);
                    actions.Add(EActions.Action8);
                    actions.Add(EActions.Action9);
                    actions.Add(EActions.Action10);
                    break;

                case EAccessLevel.Developer:
                    actions.Add(EActions.Action11);
                    actions.Add(EActions.Action12);
                    actions.Add(EActions.Action13);
                    actions.Add(EActions.Action14);
                    actions.Add(EActions.Action15);
                    break;
                default:
                    break;
            }
            return actions;
        }
    }
}

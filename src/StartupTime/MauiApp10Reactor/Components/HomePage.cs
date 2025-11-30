namespace MauiApp10Reactor.Components
{
    internal class HomePageState
    {
        public int Counter { get; set; }
    }

    partial class HomePage : Component<HomePageState>
    {
        public override VisualNode Render()
            => ContentPage(
                    ScrollView(
                        VStack(
                            Image("dotnet_bot.png")
                                .HeightRequest(185)
                                .Aspect(Aspect.AspectFit)
                                .Set(SemanticProperties.DescriptionProperty, "dot net bot in a hovercraft number nine"),

                            Label("Hello, World!")
                                .ThemeKey("Headline")
                                .Set(SemanticProperties.HeadingLevelProperty, "Level1"),

                            Label($"Welcome to {Environment.NewLine}.NET Multi-platform App UI")
                                .ThemeKey("SubHeadline")
                                .Set(SemanticProperties.HeadingLevelProperty, "Level2")
                                .Set(SemanticProperties.DescriptionProperty, "Welcome to dot net Multi platform App U I"),

                            Button(State.Counter == 0 ? "Click me" : $"Clicked {State.Counter} times!")
                                .Set(SemanticProperties.HintProperty, "Counts the number of times you click")
                                .OnClicked(() => SetState(s => s.Counter++))
                                .HFill()
                    )
                    .VCenter()
                    .Spacing(25)
                    .Padding(30, 0)
                )
            );
    }
}

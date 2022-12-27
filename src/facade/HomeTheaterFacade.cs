namespace facade
{
  public class HomeTheaterFacade
  {
    Amplifier amp;
    Tuner tuner;
    TheaterLights lights;
    StreamingPlayer player;
    Projector projector;
    Screen screen;
    PopcornPopper popper;

    public HomeTheaterFacade(Amplifier amp, 
      Tuner tuner, 
      Theaterights lights,
      StreamingPlayer player, 
      Projector projector, 
      Screen screen, 
      PopcornPopper popper)
    {
      this.lights = lights;
      this.amp = amp;
      this.tuner = tuner;
      this.player = player;
      this.projector = projector;
      this.screen = screen;
      this.popper = popper;
    }

    public void watchMovie(String movie)
    {
      System.Console.WriteLine("Playing: {0}", movie);
      popper.on();
      popper.pop();
      lights.dim(10);
      screen.down();
      projector.on();
      projector.wideScreenMode();
      amp.on();
      amp.setStreamingPlayer(player);
      amp.setSurroundSound();
      amp.setVolume(5);
      player.on();
      player.play(movie);
    }
    public void endMovie()
    {
      System.Console.WriteLine("Shutting Down the theater...");
      popper.off();
      lights.on();
      screen.up();
      projector.off();
      projector.off();
      amp.off();
      player.stop();
      player.off();
    }
  }
}
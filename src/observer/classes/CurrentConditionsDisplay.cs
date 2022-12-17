using observer.interfaces;

namespace observer.classes
{
  class CurrentConditionsDisplay : IObserver, IDisplayElement
  {

    private float temperature;
    private float humidity;
    private WeatherData weatherData;

    /*
      adding weatherData as one of its dependencies, we can inject whatever subjects we need, as long as it IS-A WeatherData object.
    */
    public CurrentConditionsDisplay(WeatherData weatherData)
    {
      this.weatherData = weatherData;
      weatherData.registerObserver(this);
    }
    public void display()
    {
      System.Console.WriteLine("Current Conditions: {0} F degrees and {1} humidity", temperature, humidity);
    }
    public void update()
    {
      this.temperature = weatherData.weatherTemperature;
      this.humidity = weatherData.weatherHumidity;
      display();
    }

  }
}
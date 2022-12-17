using System.Collections;
using observer.interfaces;

namespace observer.classes 
{
  class WeatherData : ISubject
  {
    private List<IObserver> observers;
    private float temperature;
    private float humidity;
    private float pressure;

    public float weatherTemperature
    {get {return temperature;} set {temperature = value;}}

    public float weatherHumidity
    {get {return humidity;} set {humidity= value;}}

    public float weatherPressure
    {get {return pressure;} set {pressure = value;}}
    public WeatherData()
    {
      observers = new List<IObserver>();
    }

    public void registerObserver(IObserver o)
    {
      observers.Add(o);
    }

    public void removeObserver(IObserver o)
    {
      observers.Remove(o);
    }

    public void notifyObservers()
    {
      foreach (IObserver observer in observers) 
      {
        observer.update();
      }
    }

    public void measurementsChanged() 
    {
      notifyObservers();
    }

    public void setMeasurements(float temp, float humidity, float pressure) 
    {
      this.temperature = temp;
      this.humidity = humidity;
      this.pressure = pressure;
      measurementsChanged();
    }
  }
}
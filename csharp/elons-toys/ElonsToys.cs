using System;

class RemoteControlCar
{

        public int battery = 100;
        public int distanceDriven = 0;

    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    

    public string DistanceDisplay()
    {
        return $"Driven {distanceDriven} meters";
    }

    public string BatteryDisplay()
    {
        return  battery<=0 ? "Battery empty" : $"Battery at {battery}%";
    }

    public void Drive()
    {
        if(battery>=1){
            battery-=1;
            distanceDriven += 20;
            
        }

    }
}

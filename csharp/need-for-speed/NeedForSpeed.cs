using System;

class RemoteControlCar
{

    public int speed, batteryDrain, distance=0, chargePercentage=100;
    
    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speed, int batteryDrain){
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        
        
    }

    public bool BatteryDrained()
    {
        return chargePercentage<batteryDrain  ? true : false;
    }

    public int DistanceDriven()
    {
        return this.distance;
    }

    public void Drive()
    {
        if (chargePercentage >= batteryDrain){
            this.distance += this.speed;
            this.chargePercentage -= this.batteryDrain;
            
        }

    }

    public static RemoteControlCar Nitro()
    {
         RemoteControlCar Nitro = new RemoteControlCar(50, 4);
        return Nitro;
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    public int raceTrackDistance;
    
    public RaceTrack(int raceTrackDistance){
        this.raceTrackDistance = raceTrackDistance;
    }
    

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained() )
        {
            car.Drive();
        }

        return car.DistanceDriven()  < this.raceTrackDistance ? false : true;
        
         
    }
}

﻿using System;
using ScallopCore.Network;
using ScallopCore.Sensor;
namespace ScallopCore.Events
{
  #region Sensor

  /// <summary>
  /// Event handler signature for sensor open events.
  /// </summary>
  /// <param name="sender">Identifies the object that sent the event.</param>
  /// <param name="e">Event arguments, empty.</param>
  public delegate void ScallopSensorOpenedHandler(object sender, EventArgs e);

  /// <summary>
  /// Event handler signature for sensor close events.
  /// </summary>
  /// <param name="sender">Identifies the object that sent the event.</param>
  /// <param name="e">Event arguments, empty.</param>
  public delegate void ScallopSensorClosedHandler(object sender, EventArgs e);

  /// <summary>
  /// Event handler signature for sensor error events.
  /// </summary>
  /// <param name="sender">Identifies the object that sent the event.</param>
  /// <param name="e">Event arguments, containing the error message.</param>
  public delegate void ScallopSensorStatusChangedHandler(object sender, ScallopSensorStatusChangedEventArgs e);

  /// <summary>
  /// Event arguments for sensor status changed events.
  /// </summary>
  public class ScallopSensorStatusChangedEventArgs : EventArgs
  {
    /// <summary>
    /// Possible exception that caused the error.
    /// </summary>
    public Exception CausingException;

    /// <summary>
    /// StatusChanged message.
    /// </summary>
    public string msg;

    /// <summary>
    /// The state after the event.
    /// </summary>
    public ScallopSensorState NewState;

    /// <summary>
    /// The state before the event.
    /// </summary>
    public ScallopSensorState OldState;
    
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="e">Possible exception that caused an error.</param>
    /// <param name="fromState">State before event.</param>
    /// <param name="toState">State after event.</param>
    /// <param name="msg">A freeform string message for the user.</param>
    public ScallopSensorStatusChangedEventArgs(ScallopSensorState fromState, ScallopSensorState toState, Exception e, string msg)
    {
      this.OldState = fromState;
      this.NewState = toState;
      this.CausingException = e;
      this.msg = msg;
    }
  }


  /// <summary>
  /// Event handler signature for sensor data events.
  /// </summary>
  /// <param name="sender">Identifies the object that sent the event.</param>
  /// <param name="e">Event arguments, containing the data associated with the event.</param>
  public delegate void ScallopSensorDataHandler(object sender, ScallopSensorDataEventArgs e);

  /// <summary>
  /// Event arguments for sensor data events.
  /// </summary>
  public class ScallopSensorDataEventArgs : EventArgs
  {
    /// <summary>
    /// The data content.
    /// </summary>
    public object data;

    /// <summary>
    /// Type of data.
    /// </summary>
    public Type dataType;

    /// <summary>
    /// A freeform message for the user.
    /// </summary>
    public string msg;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="data">The event sensordata.</param>
    /// <param name="msg">A message.</param>
    public ScallopSensorDataEventArgs(object data, string msg)
    {
      this.data = data;
      this.msg = msg;
      this.dataType = data.GetType();
    }
  }

  /// <summary>
  /// Event handler signature for sensor info events.
  /// </summary>
  /// <param name="sender">Identifies the object that sent the event.</param>
  /// <param name="e">Event arguments, containing the information text.</param>
  public delegate void ScallopSensorInfoHandler(object sender, ScallopInfoEventArgs e);
  
  /// <summary>
  /// Event arguments for sensor and network information events.
  /// </summary>
  public class ScallopInfoEventArgs : EventArgs
  {
    /// <summary>
    /// The information message.
    /// </summary>
    public string msg;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="msg">The information message.</param>
    public ScallopInfoEventArgs(string msg)
    {
      this.msg = msg;
    }
  }

  #endregion Sensor

  #region Network

  /// <summary>
  /// Event handler signature for network open events.
  /// </summary>
  /// <param name="sender">Identifies the object that sent the event.</param>
  /// <param name="e">Event arguments, empty.</param>
  public delegate void ScallopNetworkOpenedHandler(object sender, EventArgs e);

  /// <summary>
  /// Event handler signature for network closed events.
  /// </summary>
  /// <param name="sender">Identifies the object that sent the event.</param>
  /// <param name="e">Event arguments, empty.</param>
  public delegate void ScallopNetworkClosedHandler(object sender, EventArgs e);


  /// <summary>
  /// Event handler signature for network error events.
  /// </summary>
  /// <param name="sender">Identifies the object that sent the event.</param>
  /// <param name="e">Event arguments, containing the error message.</param>
  public delegate void ScallopNetworkStatusChangedHandler(object sender, ScallopNetworkStatusChangedEventArgs e);

  /// <summary>
  /// Event arguments for network status changed events.
  /// </summary>
  public class ScallopNetworkStatusChangedEventArgs : EventArgs
  {
    /// <summary>
    /// Possible exception that caused the error.
    /// </summary>
    public Exception CausingException;

    /// <summary>
    /// StatusChanged message.
    /// </summary>
    public string msg;

    /// <summary>
    /// State after the event.
    /// </summary>
    public ScallopNetworkState NewState;
    
    /// <summary>
    /// State before the event.
    /// </summary>
    public ScallopNetworkState OldState;

    /// <summary>
    /// Constructor.
    /// </summary>
    public ScallopNetworkStatusChangedEventArgs(ScallopNetworkState toState, Exception e, string msg)
    {
      this.NewState = toState;
      this.CausingException = e;
      this.msg = msg;
    }
  }

  /// <summary>
  /// Event handler signature for network data events.
  /// </summary>
  /// <param name="sender">Identifies the object that sent the event.</param>
  /// <param name="e">Event arguments, containing the data.</param>
  public delegate void ScallopNetworkDataHandler(object sender, ScallopNetworkDataEventArgs e);

  /// <summary>
  /// Event arguments for network data events.
  /// </summary>
  public class ScallopNetworkDataEventArgs : EventArgs
  {
    /// <summary>
    /// The data received from the network.
    /// </summary>
    public object data;

    /// <summary>
    /// Type of data.
    /// </summary>
    public Type dataType;

    /// <summary>
    /// An optional message for the user.
    /// </summary>
    public string msg;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="data">The network data.</param>
    /// <param name="msg">A user message.</param>
    public ScallopNetworkDataEventArgs(object data, string msg)
    {
      this.data = data;
      this.msg = msg;
      this.dataType = data.GetType();
    }
  }

  /// <summary>
  /// Event handler signature for network info events.
  /// </summary>
  /// <param name="sender">Identifies the object that sent the event.</param>
  /// <param name="e">Event parameters, containing the information text.</param>
  public delegate void ScallopNetworkInfoHandler(object sender, ScallopInfoEventArgs e);
  
  

  #endregion Network
}

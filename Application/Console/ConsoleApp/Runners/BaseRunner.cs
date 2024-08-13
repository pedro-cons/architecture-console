using Domain.Constants;
using Domain.Interfaces;
using System;
using System.Threading.Tasks;

/// <summary>
/// Class responsible for executing the Console logic
/// </summary>
public class BaseRunner
{
    #region Properties

    private readonly IServiceLog _serviceLog;

    #endregion

    #region Constructor

    /// <summary>
    /// Console Runner Constructor
    /// </summary>
    /// <param name="serviceLog">Log Service</param>
    public BaseRunner(IServiceLog serviceLog)
    {
        _serviceLog = serviceLog;
    }

    #endregion

    #region Methods

    /// <summary>
    /// Method responsible for starting the execution of the console
    /// </summary>
    /// <returns></returns>
    public async Task RunAsync()
    {
        try
        {
            Console.WriteLine("Starting the console execution.");


            Console.WriteLine("Ending the console execution.");
        }
        catch (Exception ex)
        {
            // Log the error
            await _serviceLog.LogError($"(Main): {ex.Message}");
        }
    }


    #endregion
}

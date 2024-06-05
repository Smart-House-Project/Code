using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouseProject
{
    public class Media
{
    List<string> channels;
    int currentChannelIndex;
    bool isOrdinaryTVOn;
    string currentYoutubeVideo;
    bool isYoutubeOpened;
    public int CurrentChannelIndex
    {
        get { return currentChannelIndex; }
        set { currentChannelIndex = value; }
    }
    public string CurrentChannel
    {
        get { return channels[currentChannelIndex]; }
        set { channels[currentChannelIndex] = value; }
    }
    public string CurrentYoutubeVideo
    {
        get { return currentYoutubeVideo; }
        set { currentYoutubeVideo = value; }
    }
    public bool IsYoutubeOpened
    {
        get { return isYoutubeOpened; }
        set { isYoutubeOpened = value; }
    }
    public void TurnOnOrdinaryTV()
    {
        isOrdinaryTVOn = true;
        Console.WriteLine("Ordinary TV is on");
        DisplayCurrentChannel();
        TVMenu();
    }

    public void TurnOffOrdinaryTV()
    {
        isOrdinaryTVOn = false;
        Console.WriteLine("Ordinary TV is off");
    }
    public void NextChannel()
    {
        if (isOrdinaryTVOn)
        {
            currentChannelIndex = (currentChannelIndex + 1) % channels.Count;
            DisplayCurrentChannel();
        }
        else
        {
            Console.WriteLine("Turn on the TV first.");
        }
    }

    public void PreviousChannel()
    {
        if (isOrdinaryTVOn)
        {
            currentChannelIndex = (currentChannelIndex - 1 + channels.Count) % channels.Count;
            DisplayCurrentChannel();
        }
        else
        {
            Console.WriteLine("Turn on the TV first.");
        }
    }

    public void DisplayCurrentChannel()
    {
        Console.WriteLine($"Current channel: {channels[currentChannelIndex]}");
    }
    public void OpenYoutube()
    {
        if (isYoutubeOpened)
        {
            Console.WriteLine("Youtube is already opened");
        }
        else
        {
            IsYoutubeOpened = true;
            Console.WriteLine("Youtube is opened");
            YoutubeMenu();
        }
    }
    public void CloseYoutube()
    {
        if (!IsYoutubeOpened)
            Console.WriteLine("Youtube is already closed");
        else
        {
            IsYoutubeOpened = false;
            Console.WriteLine("Youtube is closed");
        }
    }
    /// <summary>
    /// Шукає відео на YouTube, якщо YouTube додаток відкритий.
    /// </summary>
    /// <returns>Назва відео для пошуку або порожній рядок, якщо YouTube не відкритий.</returns>
    public string SearchYoutubeVideo()
    {
        string videoToSearch = string.Empty;
        if (isYoutubeOpened)
        {
            Console.WriteLine("Enter name of video");
            videoToSearch = Console.ReadLine();
        }
        else
            Console.WriteLine("Open Youtube firstly");
        return videoToSearch;
    }
    public void PlayYoutubeVideo()
    {
        string videoToPlay = SearchYoutubeVideo();
        if (videoToPlay != string.Empty)
        {
            CurrentYoutubeVideo = videoToPlay;
        }
        else
            Console.WriteLine("Enter name of the video firstly or close current video");
    }
    public void StopYoutubeVideo()
    {
        Console.WriteLine("Video is stopped");
    }
    public void YoutubeMenu()
    {
        Console.Clear();
        int choice;
        do
        {
            Console.WriteLine("1. Play Youtube Video");
            Console.WriteLine("2. Stop Youtube Video");
            Console.WriteLine("3. Exit");

            try
            {
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        PlayYoutubeVideo();
                        break;
                    case 2:
                        StopYoutubeVideo();
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        CloseYoutube();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                choice = -1; // Set choice to an invalid value to continue the loop
            }
            catch (OverflowException)
            {
                Console.WriteLine("Input out of range. Please enter a number within the valid range.");
                choice = -1; // Set choice to an invalid value to continue the loop
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                choice = -1; // Set choice to an invalid value to continue the loop
            }
        } while (choice != 3);
    }
    public void TVMenu()
    {
        try
        {
            Console.Clear();
            int choice;
            do
            {
                Console.WriteLine("1. Next channel");
                Console.WriteLine("2. Previous channel");
                Console.WriteLine("3. Close Ordinary TV");

                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
                {
                    Console.WriteLine("Input 1-3");
                }

                if (choice == 1)
                    NextChannel();
                else if (choice == 2)
                    PreviousChannel();
                else
                    TurnOffOrdinaryTV();

            } while (choice != 3);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Input out of range. Please enter a number within the valid range.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
    public void MediaMenu()
    {
        
        try
        {
            Console.Clear();
            int choice;
            do
            {
                Console.WriteLine("---Media menu---");
                Console.WriteLine("1.Turn on TV");
                Console.WriteLine("2.Watch Youtube");

                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
                {
                    Console.WriteLine("Input 1-2");
                }

                if (choice == 1)
                    TurnOnOrdinaryTV();
                else if (choice == 2)
                    OpenYoutube();
                else
                    Console.WriteLine("Media menu is closed...");

            } while (choice != 3);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Input out of range. Please enter a number within the valid range.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

    }
    public void ControlDevice()
    {
        throw new NotImplementedException();
    }

    public void StreamContent()
    {
        throw new NotImplementedException();
    }

    public void ManageLibrary()
    {
        throw new NotImplementedException();
    }

    public void SchedulePlayback()
    {
        throw new NotImplementedException();
    }

    public void IntegrateWithAssistant()
    {
        throw new NotImplementedException();
    }

    public Service service;

}
}

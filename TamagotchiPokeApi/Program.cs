using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using RestSharp;
using TamagotchiPokeApi.Controller;
using TamagotchiPokeApi.Model;
using TamagotchiPokeApi.Service;
using TamagotchiPokeApi.View;

namespace TamagotchiPokeApi
{
     class Program
    {
        static void Main(string[] args)
        {
            TamagotchiContoller tamagotchiContoller = new TamagotchiContoller();
            tamagotchiContoller.Jogar();
        }
    }
}

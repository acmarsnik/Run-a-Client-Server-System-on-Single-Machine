using System;
using Xunit;
using SakilaWebServer.Models;

namespace SakilaWebServer.Test
{
    public class ActorsControllerTest
    {
        public void ActorTest(Actor actor)
        {
            Assert.NotNull(actor);
            Assert.Equal(101, actor.Actor_ID);
            Assert.Equal("SUSAN", actor.First_Name);
            Assert.Equal("DAVIS", actor.Last_Name);
        }
    }
}
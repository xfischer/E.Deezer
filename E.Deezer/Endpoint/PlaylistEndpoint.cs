﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E.Deezer.Endpoint
{
    public interface IPlaylistEndpoint
    {

    }

    internal class PlaylistEndpoint : IPlaylistEndpoint
    {
        private DeezerClient iClient;


        public PlaylistEndpoint(DeezerClient aClient) {  iClient = aClient;  }
    }
}
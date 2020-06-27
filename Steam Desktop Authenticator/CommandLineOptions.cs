﻿using System;
using CommandLine;
using CommandLine.Text;

namespace Steam_Desktop_Authenticator
{
    class CommandLineOptions
    {
        [Option('k', "encryption-key", Required = false,
          HelpText = "Encryption key for manifest")]
        public string EncryptionKey { get; set; }

        [Option('s', "silent", Required = false,
          HelpText = "Start minimized")]
        public bool Silent { get; set; }

       // public static explicit operator Type(CommandLineOptions v)
       // {
          //  throw new NotImplementedException();
        }

        // [ParserState]
        //  public IParserState LastParserState { get; set; }

        //   [HelpOption]
        // public string GetUsage() => HelpText.AutoBuild(this,
        //(HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
    }


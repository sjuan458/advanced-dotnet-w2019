﻿/*
 * Copyright 2016-2019 Mohawk College of Applied Arts and Technology
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); you 
 * may not use this file except in compliance with the License. You may 
 * obtain a copy of the License at 
 * 
 * http://www.apache.org/licenses/LICENSE-2.0 
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the 
 * License for the specific language governing permissions and limitations under 
 * the License.
 * 
 * User: Nityan
 * Date: 2019-1-10
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Content
{
	public class DebugExampleClass
	{
		public DebugExampleClass()
		{
			
		}

		public string MyPropertyOne { get; set; }

		public string MyPropertyTwo { get; set; }


		public void DoWork()
		{
			Console.WriteLine(this.MyPropertyOne);
			Console.WriteLine(this.MyPropertyTwo);

			this.PrintUntil(1);
		}

		public void PrintUntil(int number)
		{
			for (int i = 0; i < number; i++)
			{
				Console.WriteLine(i);
			}
		}
	}
}

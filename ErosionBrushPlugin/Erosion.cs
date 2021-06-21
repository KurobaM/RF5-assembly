using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace ErosionBrushPlugin
{
	// Token: 0x02000E24 RID: 3620
	[Token(Token = "0x2000946")]
	public static class Erosion
	{
		// Token: 0x06005E35 RID: 24117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E45")]
		[Address(RVA = "0x2C1E050", Offset = "0x2C1E151", VA = "0x2C1E050")]
		public static void ErosionIteration(Matrix heights, Matrix erosion, Matrix sedimentSum, [Optional] CoordRect area, float erosionDurability = 0.9f, float erosionAmount = 1f, float sedimentAmount = 0.5f, int erosionFluidityIterations = 3, float ruffle = 0.1f, [Optional] Matrix torrents, [Optional] Matrix sediments, [Optional] int[] stepsArray, [Optional] int[] heightsInt, [Optional] int[] order)
		{
		}

		// Token: 0x06005E36 RID: 24118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E46")]
		[Address(RVA = "0x2C1F3B0", Offset = "0x2C1F4B1", VA = "0x2C1F3B0")]
		private static void LevelCells(float hX, float hz, ref float sX, ref float sz)
		{
		}

		// Token: 0x06005E37 RID: 24119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E47")]
		[Address(RVA = "0x2C1F420", Offset = "0x2C1F521", VA = "0x2C1F420")]
		private static void LevelCells(float h1, float h2, float h3, ref float s1, ref float s2, ref float s3)
		{
		}

		// Token: 0x06005E38 RID: 24120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E48")]
		[Address(RVA = "0x2C1F560", Offset = "0x2C1F661", VA = "0x2C1F560")]
		private static void LevelCells(float h, float hx, float hX, float hz, float hZ, ref float s, ref float sx, ref float sX, ref float sz, ref float sZ)
		{
		}

		// Token: 0x02000E25 RID: 3621
		[Token(Token = "0x200144B")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x159830", Offset = "0x159931")]
		private struct Cross
		{
			// Token: 0x06005E39 RID: 24121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AA7")]
			[Address(RVA = "0x37C9C0", Offset = "0x37CAC1", VA = "0x37C9C0")]
			public Cross(float c, float px, float nx, float pz, float nz)
			{
			}

			// Token: 0x06005E3A RID: 24122 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AA8")]
			[Address(RVA = "0x37C9E0", Offset = "0x37CAE1", VA = "0x37C9E0")]
			public Cross(Erosion.Cross src)
			{
			}

			// Token: 0x06005E3B RID: 24123 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AA9")]
			[Address(RVA = "0x37CA00", Offset = "0x37CB01", VA = "0x37CA00")]
			public Cross(Erosion.Cross c1, Erosion.Cross c2)
			{
			}

			// Token: 0x06005E3C RID: 24124 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AAA")]
			[Address(RVA = "0x37CA40", Offset = "0x37CB41", VA = "0x37CA40")]
			public Cross(float[] m, int sizeX, int sizeZ, int i)
			{
			}

			// Token: 0x06005E3D RID: 24125 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AAB")]
			[Address(RVA = "0x37CA50", Offset = "0x37CB51", VA = "0x37CA50")]
			public Cross(bool[] m, int sizeX, int sizeZ, int i)
			{
			}

			// Token: 0x06005E3E RID: 24126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AAC")]
			[Address(RVA = "0x37CA60", Offset = "0x37CB61", VA = "0x37CA60")]
			public Cross(Matrix m, int i)
			{
			}

			// Token: 0x06005E3F RID: 24127 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AAD")]
			[Address(RVA = "0x37CA70", Offset = "0x37CB71", VA = "0x37CA70")]
			public void ToMatrix(float[] m, int sizeX, int sizeZ, int i)
			{
			}

			// Token: 0x06005E40 RID: 24128 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AAE")]
			[Address(RVA = "0x37CA80", Offset = "0x37CB81", VA = "0x37CA80")]
			public void ToMatrix(Matrix m, int i)
			{
			}

			// Token: 0x06005E41 RID: 24129 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AAF")]
			[Address(RVA = "0x37CA90", Offset = "0x37CB91", VA = "0x37CA90")]
			public void Percent()
			{
			}

			// Token: 0x06005E42 RID: 24130 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AB0")]
			[Address(RVA = "0x37CB00", Offset = "0x37CC01", VA = "0x37CB00")]
			public void ClampPositive()
			{
			}

			// Token: 0x17000C57 RID: 3159
			// (get) Token: 0x06005E43 RID: 24131 RVA: 0x0001F2A8 File Offset: 0x0001D4A8
			[Token(Token = "0x17000E59")]
			public float max
			{
				[Token(Token = "0x6007AB1")]
				[Address(RVA = "0x37CB40", Offset = "0x37CC41", VA = "0x37CB40")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000C58 RID: 3160
			// (get) Token: 0x06005E44 RID: 24132 RVA: 0x0001F2C0 File Offset: 0x0001D4C0
			[Token(Token = "0x17000E5A")]
			public float min
			{
				[Token(Token = "0x6007AB2")]
				[Address(RVA = "0x37CB50", Offset = "0x37CC51", VA = "0x37CB50")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000C59 RID: 3161
			// (get) Token: 0x06005E45 RID: 24133 RVA: 0x0001F2D8 File Offset: 0x0001D4D8
			[Token(Token = "0x17000E5B")]
			public float sum
			{
				[Token(Token = "0x6007AB3")]
				[Address(RVA = "0x37CB60", Offset = "0x37CC61", VA = "0x37CB60")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000C5A RID: 3162
			// (get) Token: 0x06005E46 RID: 24134 RVA: 0x0001F2F0 File Offset: 0x0001D4F0
			[Token(Token = "0x17000E5C")]
			public float avg
			{
				[Token(Token = "0x6007AB4")]
				[Address(RVA = "0x37CB80", Offset = "0x37CC81", VA = "0x37CB80")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000C5B RID: 3163
			// (get) Token: 0x06005E47 RID: 24135 RVA: 0x0001F308 File Offset: 0x0001D508
			[Token(Token = "0x17000E5D")]
			public float avgAround
			{
				[Token(Token = "0x6007AB5")]
				[Address(RVA = "0x37CBB0", Offset = "0x37CCB1", VA = "0x37CBB0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000C5C RID: 3164
			// (get) Token: 0x06005E48 RID: 24136 RVA: 0x0001F320 File Offset: 0x0001D520
			[Token(Token = "0x17000E5E")]
			public float maxAround
			{
				[Token(Token = "0x6007AB6")]
				[Address(RVA = "0x37CBD0", Offset = "0x37CCD1", VA = "0x37CBD0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000C5D RID: 3165
			// (get) Token: 0x06005E49 RID: 24137 RVA: 0x0001F338 File Offset: 0x0001D538
			[Token(Token = "0x17000E5F")]
			public float minAround
			{
				[Token(Token = "0x6007AB7")]
				[Address(RVA = "0x37CC70", Offset = "0x37CD71", VA = "0x37CC70")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06005E4A RID: 24138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AB8")]
			[Address(RVA = "0x37CD10", Offset = "0x37CE11", VA = "0x37CD10")]
			public void Multiply(Erosion.Cross c2)
			{
			}

			// Token: 0x06005E4B RID: 24139 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AB9")]
			[Address(RVA = "0x37CD50", Offset = "0x37CE51", VA = "0x37CD50")]
			public void Multiply(float f)
			{
			}

			// Token: 0x06005E4C RID: 24140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007ABA")]
			[Address(RVA = "0x37CD90", Offset = "0x37CE91", VA = "0x37CD90")]
			public void Add(Erosion.Cross c2)
			{
			}

			// Token: 0x06005E4D RID: 24141 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007ABB")]
			[Address(RVA = "0x37CDD0", Offset = "0x37CED1", VA = "0x37CDD0")]
			public void Divide(Erosion.Cross c2)
			{
			}

			// Token: 0x06005E4E RID: 24142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007ABC")]
			[Address(RVA = "0x37CE20", Offset = "0x37CF21", VA = "0x37CE20")]
			public void Divide(float f)
			{
			}

			// Token: 0x06005E4F RID: 24143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007ABD")]
			[Address(RVA = "0x37CE60", Offset = "0x37CF61", VA = "0x37CE60")]
			public void Subtract(float f)
			{
			}

			// Token: 0x06005E50 RID: 24144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007ABE")]
			[Address(RVA = "0x37CEA0", Offset = "0x37CFA1", VA = "0x37CEA0")]
			public void SubtractInverse(float f)
			{
			}

			// Token: 0x06005E51 RID: 24145 RVA: 0x0001F350 File Offset: 0x0001D550
			[Token(Token = "0x6007ABF")]
			[Address(RVA = "0x37CEE0", Offset = "0x37CFE1", VA = "0x37CEE0")]
			public float GetMultipliedMax(Erosion.Cross c2)
			{
				return 0f;
			}

			// Token: 0x06005E52 RID: 24146 RVA: 0x0001F368 File Offset: 0x0001D568
			[Token(Token = "0x6007AC0")]
			[Address(RVA = "0x37CF20", Offset = "0x37D021", VA = "0x37CF20")]
			public float GetMultipliedSum(Erosion.Cross c2)
			{
				return 0f;
			}

			// Token: 0x17000C5E RID: 3166
			// (get) Token: 0x06005E53 RID: 24147 RVA: 0x0001F380 File Offset: 0x0001D580
			[Token(Token = "0x17000E60")]
			public bool isNaN
			{
				[Token(Token = "0x6007AC1")]
				[Address(RVA = "0x37CF60", Offset = "0x37D061", VA = "0x37CF60")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000C5F RID: 3167
			// (get) Token: 0x06005E54 RID: 24148 RVA: 0x0001F398 File Offset: 0x0001D598
			// (set) Token: 0x06005E55 RID: 24149 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E61")]
			public float Item
			{
				[Token(Token = "0x6007AC2")]
				[Address(RVA = "0x37CFE0", Offset = "0x37D0E1", VA = "0x37CFE0")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6007AC3")]
				[Address(RVA = "0x37D030", Offset = "0x37D131", VA = "0x37D030")]
				set
				{
				}
			}

			// Token: 0x06005E56 RID: 24150 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AC4")]
			[Address(RVA = "0x37D080", Offset = "0x37D181", VA = "0x37D080")]
			public void SortByHeight(int[] sorted)
			{
			}

			// Token: 0x06005E57 RID: 24151 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007AC5")]
			[Address(RVA = "0x37D090", Offset = "0x37D191", VA = "0x37D090")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B5230", Offset = "0x1B5331")]
			public IEnumerable<int> Sorted()
			{
				return null;
			}

			// Token: 0x06005E58 RID: 24152 RVA: 0x0001F3B0 File Offset: 0x0001D5B0
			[Token(Token = "0x6007AC6")]
			[Address(RVA = "0x2C207F0", Offset = "0x2C208F1", VA = "0x2C207F0")]
			public static Erosion.Cross operator +(Erosion.Cross c1, Erosion.Cross c2)
			{
				return default(Erosion.Cross);
			}

			// Token: 0x06005E59 RID: 24153 RVA: 0x0001F3C8 File Offset: 0x0001D5C8
			[Token(Token = "0x6007AC7")]
			[Address(RVA = "0x2C20830", Offset = "0x2C20931", VA = "0x2C20830")]
			public static Erosion.Cross operator +(Erosion.Cross c1, float f)
			{
				return default(Erosion.Cross);
			}

			// Token: 0x06005E5A RID: 24154 RVA: 0x0001F3E0 File Offset: 0x0001D5E0
			[Token(Token = "0x6007AC8")]
			[Address(RVA = "0x2C20870", Offset = "0x2C20971", VA = "0x2C20870")]
			public static Erosion.Cross operator -(Erosion.Cross c1, Erosion.Cross c2)
			{
				return default(Erosion.Cross);
			}

			// Token: 0x06005E5B RID: 24155 RVA: 0x0001F3F8 File Offset: 0x0001D5F8
			[Token(Token = "0x6007AC9")]
			[Address(RVA = "0x2C208B0", Offset = "0x2C209B1", VA = "0x2C208B0")]
			public static Erosion.Cross operator -(float f, Erosion.Cross c2)
			{
				return default(Erosion.Cross);
			}

			// Token: 0x06005E5C RID: 24156 RVA: 0x0001F410 File Offset: 0x0001D610
			[Token(Token = "0x6007ACA")]
			[Address(RVA = "0x2C208F0", Offset = "0x2C209F1", VA = "0x2C208F0")]
			public static Erosion.Cross operator -(Erosion.Cross c1, float f)
			{
				return default(Erosion.Cross);
			}

			// Token: 0x06005E5D RID: 24157 RVA: 0x0001F428 File Offset: 0x0001D628
			[Token(Token = "0x6007ACB")]
			[Address(RVA = "0x2C20930", Offset = "0x2C20A31", VA = "0x2C20930")]
			public static Erosion.Cross operator *(Erosion.Cross c1, Erosion.Cross c2)
			{
				return default(Erosion.Cross);
			}

			// Token: 0x06005E5E RID: 24158 RVA: 0x0001F440 File Offset: 0x0001D640
			[Token(Token = "0x6007ACC")]
			[Address(RVA = "0x2C20970", Offset = "0x2C20A71", VA = "0x2C20970")]
			public static Erosion.Cross operator *(float f, Erosion.Cross c2)
			{
				return default(Erosion.Cross);
			}

			// Token: 0x06005E5F RID: 24159 RVA: 0x0001F458 File Offset: 0x0001D658
			[Token(Token = "0x6007ACD")]
			[Address(RVA = "0x2C209B0", Offset = "0x2C20AB1", VA = "0x2C209B0")]
			public static Erosion.Cross operator *(Erosion.Cross c1, float f)
			{
				return default(Erosion.Cross);
			}

			// Token: 0x06005E60 RID: 24160 RVA: 0x0001F470 File Offset: 0x0001D670
			[Token(Token = "0x6007ACE")]
			[Address(RVA = "0x2C209F0", Offset = "0x2C20AF1", VA = "0x2C209F0")]
			public static Erosion.Cross operator /(Erosion.Cross c1, float f)
			{
				return default(Erosion.Cross);
			}

			// Token: 0x06005E61 RID: 24161 RVA: 0x0001F488 File Offset: 0x0001D688
			[Token(Token = "0x6007ACF")]
			[Address(RVA = "0x37D140", Offset = "0x37D241", VA = "0x37D140")]
			public Erosion.Cross PercentObsolete()
			{
				return default(Erosion.Cross);
			}

			// Token: 0x06005E62 RID: 24162 RVA: 0x0001F4A0 File Offset: 0x0001D6A0
			[Token(Token = "0x6007AD0")]
			[Address(RVA = "0x37D1C0", Offset = "0x37D2C1", VA = "0x37D1C0")]
			public Erosion.Cross ClampPositiveObsolete()
			{
				return default(Erosion.Cross);
			}

			// Token: 0x0400BE50 RID: 48720
			[Token(Token = "0x401BBC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float c;

			// Token: 0x0400BE51 RID: 48721
			[Token(Token = "0x401BBC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float px;

			// Token: 0x0400BE52 RID: 48722
			[Token(Token = "0x401BBC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float nx;

			// Token: 0x0400BE53 RID: 48723
			[Token(Token = "0x401BBC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float pz;

			// Token: 0x0400BE54 RID: 48724
			[Token(Token = "0x401BBC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float nz;

			// Token: 0x02000E26 RID: 3622
			[Token(Token = "0x2001666")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AE50", Offset = "0x15AF51")]
			private sealed class <Sorted>d__44 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
			{
				// Token: 0x06005E63 RID: 24163 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080D0")]
				[Address(RVA = "0x2C207B0", Offset = "0x2C208B1", VA = "0x2C207B0")]
				[DebuggerHidden]
				public <Sorted>d__44(int <>1__state)
				{
				}

				// Token: 0x06005E64 RID: 24164 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080D1")]
				[Address(RVA = "0x2C20B20", Offset = "0x2C20C21", VA = "0x2C20B20", Slot = "7")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06005E65 RID: 24165 RVA: 0x0001F4B8 File Offset: 0x0001D6B8
				[Token(Token = "0x60080D2")]
				[Address(RVA = "0x2C20B30", Offset = "0x2C20C31", VA = "0x2C20B30", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000C60 RID: 3168
				// (get) Token: 0x06005E66 RID: 24166 RVA: 0x0001F4D0 File Offset: 0x0001D6D0
				[Token(Token = "0x17000F57")]
				private int Current
				{
					[Token(Token = "0x60080D3")]
					[Address(RVA = "0x2C21320", Offset = "0x2C21421", VA = "0x2C21320", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005E67 RID: 24167 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080D4")]
				[Address(RVA = "0x2C21330", Offset = "0x2C21431", VA = "0x2C21330", Slot = "10")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000C61 RID: 3169
				// (get) Token: 0x06005E68 RID: 24168 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F58")]
				private object Current
				{
					[Token(Token = "0x60080D5")]
					[Address(RVA = "0x2C21390", Offset = "0x2C21491", VA = "0x2C21390", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x06005E69 RID: 24169 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60080D6")]
				[Address(RVA = "0x2C21400", Offset = "0x2C21501", VA = "0x2C21400", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<int> GetEnumerator()
				{
					return null;
				}

				// Token: 0x06005E6A RID: 24170 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60080D7")]
				[Address(RVA = "0x2C214F0", Offset = "0x2C215F1", VA = "0x2C214F0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator GetEnumerator()
				{
					return null;
				}

				// Token: 0x0400BE55 RID: 48725
				[Token(Token = "0x401C44C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0400BE56 RID: 48726
				[Token(Token = "0x401C44D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				private int <>2__current;

				// Token: 0x0400BE57 RID: 48727
				[Token(Token = "0x401C44E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private int <>l__initialThreadId;

				// Token: 0x0400BE58 RID: 48728
				[Token(Token = "0x401C44F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public Erosion.Cross <>4__this;

				// Token: 0x0400BE59 RID: 48729
				[Token(Token = "0x401C450")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public Erosion.Cross <>3__<>4__this;

				// Token: 0x0400BE5A RID: 48730
				[Token(Token = "0x401C451")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
				private float <_c>5__2;

				// Token: 0x0400BE5B RID: 48731
				[Token(Token = "0x401C452")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private float <_px>5__3;

				// Token: 0x0400BE5C RID: 48732
				[Token(Token = "0x401C453")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
				private float <_nx>5__4;

				// Token: 0x0400BE5D RID: 48733
				[Token(Token = "0x401C454")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private float <_pz>5__5;

				// Token: 0x0400BE5E RID: 48734
				[Token(Token = "0x401C455")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
				private float <_nz>5__6;

				// Token: 0x0400BE5F RID: 48735
				[Token(Token = "0x401C456")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private int <i>5__7;
			}
		}

		// Token: 0x02000E27 RID: 3623
		[Token(Token = "0x200144C")]
		private struct MooreCross
		{
			// Token: 0x06005E6B RID: 24171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AD1")]
			[Address(RVA = "0x37D200", Offset = "0x37D301", VA = "0x37D200")]
			public MooreCross(float c, float px, float nx, float pz, float nz, float pxpz, float nxpz, float pxnz, float nxnz)
			{
			}

			// Token: 0x06005E6C RID: 24172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AD2")]
			[Address(RVA = "0x37D230", Offset = "0x37D331", VA = "0x37D230")]
			public MooreCross(Erosion.MooreCross src)
			{
			}

			// Token: 0x06005E6D RID: 24173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AD3")]
			[Address(RVA = "0x37D250", Offset = "0x37D351", VA = "0x37D250")]
			public MooreCross(float[] m, int sizeX, int sizeZ, int i)
			{
			}

			// Token: 0x06005E6E RID: 24174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AD4")]
			[Address(RVA = "0x37D260", Offset = "0x37D361", VA = "0x37D260")]
			public MooreCross(Matrix m, int i)
			{
			}

			// Token: 0x06005E6F RID: 24175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AD5")]
			[Address(RVA = "0x37D270", Offset = "0x37D371", VA = "0x37D270")]
			public void ToMatrix(float[] m, int sizeX, int sizeZ, int i)
			{
			}

			// Token: 0x06005E70 RID: 24176 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AD6")]
			[Address(RVA = "0x37D280", Offset = "0x37D381", VA = "0x37D280")]
			public void ToMatrix(Matrix m, int i)
			{
			}

			// Token: 0x06005E71 RID: 24177 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AD7")]
			[Address(RVA = "0x37D290", Offset = "0x37D391", VA = "0x37D290")]
			public void Percent()
			{
			}

			// Token: 0x17000C62 RID: 3170
			// (get) Token: 0x06005E72 RID: 24178 RVA: 0x0001F4E8 File Offset: 0x0001D6E8
			[Token(Token = "0x17000E62")]
			public bool isNaN
			{
				[Token(Token = "0x6007AD8")]
				[Address(RVA = "0x37D330", Offset = "0x37D431", VA = "0x37D330")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06005E73 RID: 24179 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007AD9")]
			[Address(RVA = "0x37D340", Offset = "0x37D441", VA = "0x37D340", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06005E74 RID: 24180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007ADA")]
			[Address(RVA = "0x37D350", Offset = "0x37D451", VA = "0x37D350")]
			public void ClampPositive()
			{
			}

			// Token: 0x17000C63 RID: 3171
			// (get) Token: 0x06005E75 RID: 24181 RVA: 0x0001F500 File Offset: 0x0001D700
			[Token(Token = "0x17000E63")]
			public float max
			{
				[Token(Token = "0x6007ADB")]
				[Address(RVA = "0x37D3C0", Offset = "0x37D4C1", VA = "0x37D3C0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000C64 RID: 3172
			// (get) Token: 0x06005E76 RID: 24182 RVA: 0x0001F518 File Offset: 0x0001D718
			[Token(Token = "0x17000E64")]
			public float min
			{
				[Token(Token = "0x6007ADC")]
				[Address(RVA = "0x37D3D0", Offset = "0x37D4D1", VA = "0x37D3D0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000C65 RID: 3173
			// (get) Token: 0x06005E77 RID: 24183 RVA: 0x0001F530 File Offset: 0x0001D730
			[Token(Token = "0x17000E65")]
			public float sum
			{
				[Token(Token = "0x6007ADD")]
				[Address(RVA = "0x37D3E0", Offset = "0x37D4E1", VA = "0x37D3E0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06005E78 RID: 24184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007ADE")]
			[Address(RVA = "0x37D400", Offset = "0x37D501", VA = "0x37D400")]
			public void Multiply(float f)
			{
			}

			// Token: 0x06005E79 RID: 24185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007ADF")]
			[Address(RVA = "0x37D460", Offset = "0x37D561", VA = "0x37D460")]
			public void Add(float f)
			{
			}

			// Token: 0x06005E7A RID: 24186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AE0")]
			[Address(RVA = "0x37D4C0", Offset = "0x37D5C1", VA = "0x37D4C0")]
			public void Add(Erosion.MooreCross c2)
			{
			}

			// Token: 0x06005E7B RID: 24187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AE1")]
			[Address(RVA = "0x37D530", Offset = "0x37D631", VA = "0x37D530")]
			public void Subtract(float f)
			{
			}

			// Token: 0x06005E7C RID: 24188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AE2")]
			[Address(RVA = "0x37D590", Offset = "0x37D691", VA = "0x37D590")]
			public void SubtractInverse(float f)
			{
			}

			// Token: 0x06005E7D RID: 24189 RVA: 0x0001F548 File Offset: 0x0001D748
			[Token(Token = "0x6007AE3")]
			[Address(RVA = "0x2C22600", Offset = "0x2C22701", VA = "0x2C22600")]
			public static Erosion.MooreCross operator +(Erosion.MooreCross c1, Erosion.MooreCross c2)
			{
				return default(Erosion.MooreCross);
			}

			// Token: 0x06005E7E RID: 24190 RVA: 0x0001F560 File Offset: 0x0001D760
			[Token(Token = "0x6007AE4")]
			[Address(RVA = "0x2C22670", Offset = "0x2C22771", VA = "0x2C22670")]
			public static Erosion.MooreCross operator +(Erosion.MooreCross c1, float f)
			{
				return default(Erosion.MooreCross);
			}

			// Token: 0x06005E7F RID: 24191 RVA: 0x0001F578 File Offset: 0x0001D778
			[Token(Token = "0x6007AE5")]
			[Address(RVA = "0x2C226D0", Offset = "0x2C227D1", VA = "0x2C226D0")]
			public static Erosion.MooreCross operator -(Erosion.MooreCross c1, Erosion.MooreCross c2)
			{
				return default(Erosion.MooreCross);
			}

			// Token: 0x06005E80 RID: 24192 RVA: 0x0001F590 File Offset: 0x0001D790
			[Token(Token = "0x6007AE6")]
			[Address(RVA = "0x2C22740", Offset = "0x2C22841", VA = "0x2C22740")]
			public static Erosion.MooreCross operator -(float f, Erosion.MooreCross c2)
			{
				return default(Erosion.MooreCross);
			}

			// Token: 0x06005E81 RID: 24193 RVA: 0x0001F5A8 File Offset: 0x0001D7A8
			[Token(Token = "0x6007AE7")]
			[Address(RVA = "0x2C227A0", Offset = "0x2C228A1", VA = "0x2C227A0")]
			public static Erosion.MooreCross operator -(Erosion.MooreCross c1, float f)
			{
				return default(Erosion.MooreCross);
			}

			// Token: 0x06005E82 RID: 24194 RVA: 0x0001F5C0 File Offset: 0x0001D7C0
			[Token(Token = "0x6007AE8")]
			[Address(RVA = "0x2C22800", Offset = "0x2C22901", VA = "0x2C22800")]
			public static Erosion.MooreCross operator *(Erosion.MooreCross c1, Erosion.MooreCross c2)
			{
				return default(Erosion.MooreCross);
			}

			// Token: 0x06005E83 RID: 24195 RVA: 0x0001F5D8 File Offset: 0x0001D7D8
			[Token(Token = "0x6007AE9")]
			[Address(RVA = "0x2C22870", Offset = "0x2C22971", VA = "0x2C22870")]
			public static Erosion.MooreCross operator *(float f, Erosion.MooreCross c2)
			{
				return default(Erosion.MooreCross);
			}

			// Token: 0x06005E84 RID: 24196 RVA: 0x0001F5F0 File Offset: 0x0001D7F0
			[Token(Token = "0x6007AEA")]
			[Address(RVA = "0x2C228D0", Offset = "0x2C229D1", VA = "0x2C228D0")]
			public static Erosion.MooreCross operator *(Erosion.MooreCross c1, float f)
			{
				return default(Erosion.MooreCross);
			}

			// Token: 0x06005E85 RID: 24197 RVA: 0x0001F608 File Offset: 0x0001D808
			[Token(Token = "0x6007AEB")]
			[Address(RVA = "0x2C22930", Offset = "0x2C22A31", VA = "0x2C22930")]
			public static Erosion.MooreCross operator /(Erosion.MooreCross c1, float f)
			{
				return default(Erosion.MooreCross);
			}

			// Token: 0x06005E86 RID: 24198 RVA: 0x0001F620 File Offset: 0x0001D820
			[Token(Token = "0x6007AEC")]
			[Address(RVA = "0x37D5F0", Offset = "0x37D6F1", VA = "0x37D5F0")]
			public Erosion.MooreCross PercentObsolete()
			{
				return default(Erosion.MooreCross);
			}

			// Token: 0x06005E87 RID: 24199 RVA: 0x0001F638 File Offset: 0x0001D838
			[Token(Token = "0x6007AED")]
			[Address(RVA = "0x37D6C0", Offset = "0x37D7C1", VA = "0x37D6C0")]
			public Erosion.MooreCross ClampPositiveObsolete()
			{
				return default(Erosion.MooreCross);
			}

			// Token: 0x0400BE60 RID: 48736
			[Token(Token = "0x401BBC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float c;

			// Token: 0x0400BE61 RID: 48737
			[Token(Token = "0x401BBC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float px;

			// Token: 0x0400BE62 RID: 48738
			[Token(Token = "0x401BBC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float nx;

			// Token: 0x0400BE63 RID: 48739
			[Token(Token = "0x401BBC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float pxpz;

			// Token: 0x0400BE64 RID: 48740
			[Token(Token = "0x401BBC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float nxpz;

			// Token: 0x0400BE65 RID: 48741
			[Token(Token = "0x401BBCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pz;

			// Token: 0x0400BE66 RID: 48742
			[Token(Token = "0x401BBCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float nz;

			// Token: 0x0400BE67 RID: 48743
			[Token(Token = "0x401BBCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float pxnz;

			// Token: 0x0400BE68 RID: 48744
			[Token(Token = "0x401BBCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float nxnz;
		}
	}
}

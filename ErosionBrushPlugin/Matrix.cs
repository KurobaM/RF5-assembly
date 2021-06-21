using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ErosionBrushPlugin
{
	// Token: 0x02000E2C RID: 3628
	[Token(Token = "0x2000948")]
	[Serializable]
	public class Matrix : Matrix2<float>
	{
		// Token: 0x06005ED8 RID: 24280 RVA: 0x0001F998 File Offset: 0x0001DB98
		[Token(Token = "0x6004E81")]
		[Address(RVA = "0x2C2B2B0", Offset = "0x2C2B3B1", VA = "0x2C2B2B0")]
		public float GetInterpolatedValue(Vector2 pos)
		{
			return 0f;
		}

		// Token: 0x06005ED9 RID: 24281 RVA: 0x0001F9B0 File Offset: 0x0001DBB0
		[Token(Token = "0x6004E82")]
		[Address(RVA = "0x2C2B410", Offset = "0x2C2B511", VA = "0x2C2B410")]
		public float GetAveragedValue(int x, int z, int steps)
		{
			return 0f;
		}

		// Token: 0x06005EDA RID: 24282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E83")]
		[Address(RVA = "0x2C2B520", Offset = "0x2C2B621", VA = "0x2C2B520")]
		public Matrix()
		{
		}

		// Token: 0x06005EDB RID: 24283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E84")]
		[Address(RVA = "0x2C1F130", Offset = "0x2C1F231", VA = "0x2C1F130")]
		public Matrix(CoordRect rect, [Optional] float[] array)
		{
		}

		// Token: 0x06005EDC RID: 24284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E85")]
		[Address(RVA = "0x2C2B5E0", Offset = "0x2C2B6E1", VA = "0x2C2B5E0")]
		public Matrix(Coord offset, Coord size, [Optional] float[] array)
		{
		}

		// Token: 0x06005EDD RID: 24285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E86")]
		[Address(RVA = "0x2C2B860", Offset = "0x2C2B961", VA = "0x2C2B860", Slot = "5")]
		public override object Clone()
		{
			return null;
		}

		// Token: 0x06005EDE RID: 24286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E87")]
		[Address(RVA = "0x2C243A0", Offset = "0x2C244A1", VA = "0x2C243A0")]
		public Matrix Copy([Optional] Matrix result)
		{
			return null;
		}

		// Token: 0x06005EDF RID: 24287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E88")]
		[Address(RVA = "0x2C2B870", Offset = "0x2C2B971", VA = "0x2C2B870")]
		public bool[] InRect([Optional] CoordRect area)
		{
			return null;
		}

		// Token: 0x06005EE0 RID: 24288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E89")]
		[Address(RVA = "0x2C2BA20", Offset = "0x2C2BB21", VA = "0x2C2BA20")]
		public void Fill(float[,] array, CoordRect arrayRect)
		{
		}

		// Token: 0x06005EE1 RID: 24289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E8A")]
		[Address(RVA = "0x2C2BC00", Offset = "0x2C2BD01", VA = "0x2C2BC00")]
		public void Pour(float[,] array, CoordRect arrayRect)
		{
		}

		// Token: 0x06005EE2 RID: 24290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E8B")]
		[Address(RVA = "0x2C2BDF0", Offset = "0x2C2BEF1", VA = "0x2C2BDF0")]
		public void Pour(float[,,] array, int channel, CoordRect arrayRect)
		{
		}

		// Token: 0x06005EE3 RID: 24291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E8C")]
		[Address(RVA = "0x2C2C000", Offset = "0x2C2C101", VA = "0x2C2C000")]
		public float[,] ReadHeighmap(TerrainData data, float height = 1f)
		{
			return null;
		}

		// Token: 0x06005EE4 RID: 24292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E8D")]
		[Address(RVA = "0x2C2C270", Offset = "0x2C2C371", VA = "0x2C2C270")]
		public void WriteHeightmap(TerrainData data, [Optional] float[,] array, float brushFallof = 0.5f, bool delayLod = false)
		{
		}

		// Token: 0x06005EE5 RID: 24293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E8E")]
		[Address(RVA = "0x2C2C770", Offset = "0x2C2C871", VA = "0x2C2C770")]
		public float[,,] ReadSplatmap(TerrainData data, int channel, [Optional] float[,,] array)
		{
			return null;
		}

		// Token: 0x06005EE6 RID: 24294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E8F")]
		[Address(RVA = "0x2C2CA00", Offset = "0x2C2CB01", VA = "0x2C2CA00")]
		public static void AddSplatmaps(TerrainData data, Matrix[] matrices, int[] channels, float[] opacity, [Optional] float[,,] array, float brushFallof = 0.5f)
		{
		}

		// Token: 0x06005EE7 RID: 24295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E90")]
		[Address(RVA = "0x2C2D260", Offset = "0x2C2D361", VA = "0x2C2D260")]
		public void ToTexture([Optional] Texture2D texture, [Optional] Color[] colors, float rangeMin = 0f, float rangeMax = 1f, bool resizeTexture = false)
		{
		}

		// Token: 0x06005EE8 RID: 24296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E91")]
		[Address(RVA = "0x2C2D670", Offset = "0x2C2D771", VA = "0x2C2D670")]
		public void FromTexture(Texture2D texture)
		{
		}

		// Token: 0x06005EE9 RID: 24297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E92")]
		[Address(RVA = "0x2C2D8C0", Offset = "0x2C2D9C1", VA = "0x2C2D8C0")]
		public void FromTextureTiled(Texture2D texture)
		{
		}

		// Token: 0x06005EEA RID: 24298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E93")]
		[Address(RVA = "0x2C2DA40", Offset = "0x2C2DB41", VA = "0x2C2DA40")]
		public Texture2D SimpleToTexture([Optional] Texture2D texture, [Optional] Color[] colors, float rangeMin = 0f, float rangeMax = 1f, [Optional] string savePath)
		{
			return null;
		}

		// Token: 0x06005EEB RID: 24299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E94")]
		[Address(RVA = "0x2C2DCA0", Offset = "0x2C2DDA1", VA = "0x2C2DCA0")]
		public void SimpleFromTexture(Texture2D texture)
		{
		}

		// Token: 0x06005EEC RID: 24300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E95")]
		[Address(RVA = "0x2C2DE10", Offset = "0x2C2DF11", VA = "0x2C2DE10")]
		public void ImportRaw(string path)
		{
		}

		// Token: 0x06005EED RID: 24301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E96")]
		[Address(RVA = "0x2C2E0A0", Offset = "0x2C2E1A1", VA = "0x2C2E0A0")]
		public void Replicate(Matrix source, bool tile = false)
		{
		}

		// Token: 0x06005EEE RID: 24302 RVA: 0x0001F9C8 File Offset: 0x0001DBC8
		[Token(Token = "0x6004E97")]
		[Address(RVA = "0x2C2E280", Offset = "0x2C2E381", VA = "0x2C2E280")]
		public float GetArea(int x, int z, int range)
		{
			return 0f;
		}

		// Token: 0x06005EEF RID: 24303 RVA: 0x0001F9E0 File Offset: 0x0001DBE0
		[Token(Token = "0x6004E98")]
		[Address(RVA = "0x2C2E3F0", Offset = "0x2C2E4F1", VA = "0x2C2E3F0")]
		public float GetInterpolated(float x, float z)
		{
			return 0f;
		}

		// Token: 0x06005EF0 RID: 24304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E99")]
		[Address(RVA = "0x2C247F0", Offset = "0x2C248F1", VA = "0x2C247F0")]
		public Matrix Resize(CoordRect newRect, [Optional] Matrix result)
		{
			return null;
		}

		// Token: 0x06005EF1 RID: 24305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E9A")]
		[Address(RVA = "0x2C24540", Offset = "0x2C24641", VA = "0x2C24540")]
		public Matrix Downscale(int factor, [Optional] Matrix result)
		{
			return null;
		}

		// Token: 0x06005EF2 RID: 24306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E9B")]
		[Address(RVA = "0x2C245B0", Offset = "0x2C246B1", VA = "0x2C245B0")]
		public Matrix Upscale(int factor, [Optional] Matrix result)
		{
			return null;
		}

		// Token: 0x06005EF3 RID: 24307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E9C")]
		[Address(RVA = "0x2C2E520", Offset = "0x2C2E621", VA = "0x2C2E520")]
		public Matrix BlurredUpscale(int factor)
		{
			return null;
		}

		// Token: 0x06005EF4 RID: 24308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E9D")]
		[Address(RVA = "0x2C2EC90", Offset = "0x2C2ED91", VA = "0x2C2EC90")]
		public Matrix OutdatedResize(CoordRect newRect, float smoothness = 1f, [Optional] Matrix result)
		{
			return null;
		}

		// Token: 0x06005EF5 RID: 24309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E9E")]
		[Address(RVA = "0x2C2F2D0", Offset = "0x2C2F3D1", VA = "0x2C2F2D0")]
		public Matrix OutdatedUpscale(int factor, [Optional] Matrix result)
		{
			return null;
		}

		// Token: 0x06005EF6 RID: 24310 RVA: 0x0001F9F8 File Offset: 0x0001DBF8
		[Token(Token = "0x6004E9F")]
		[Address(RVA = "0x2C2FCF0", Offset = "0x2C2FDF1", VA = "0x2C2FCF0")]
		public float OutdatedGetInterpolated(float x, float z)
		{
			return 0f;
		}

		// Token: 0x06005EF7 RID: 24311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EA0")]
		[Address(RVA = "0x2C2FE10", Offset = "0x2C2FF11", VA = "0x2C2FE10")]
		public Matrix TestResize(CoordRect newRect)
		{
			return null;
		}

		// Token: 0x06005EF8 RID: 24312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EA1")]
		[Address(RVA = "0x2C2F6A0", Offset = "0x2C2F7A1", VA = "0x2C2F6A0")]
		public Matrix OutdatedDownscale(int factor = 2, float smoothness = 1f, [Optional] Matrix result)
		{
			return null;
		}

		// Token: 0x06005EF9 RID: 24313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA2")]
		[Address(RVA = "0x2C2FFC0", Offset = "0x2C300C1", VA = "0x2C2FFC0")]
		public void Spread(float strength = 0.5f, int iterations = 4, [Optional] Matrix copy)
		{
		}

		// Token: 0x06005EFA RID: 24314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA3")]
		[Address(RVA = "0x2C30690", Offset = "0x2C30791", VA = "0x2C30690")]
		public void Spread([Optional] Func<float, float, float> spreadFn, int iterations = 4)
		{
		}

		// Token: 0x06005EFB RID: 24315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA4")]
		[Address(RVA = "0x2C2E770", Offset = "0x2C2E871", VA = "0x2C2E770")]
		public void Blur([Optional] Func<float, float, float, float> blurFn, float intensity = 0.666f, bool additive = false, bool takemax = false, bool horizontal = true, bool vertical = true, [Optional] Matrix reference)
		{
		}

		// Token: 0x06005EFC RID: 24316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA5")]
		[Address(RVA = "0x2C30AD0", Offset = "0x2C30BD1", VA = "0x2C30AD0")]
		public void LossBlur(int step = 2, bool horizontal = true, bool vertical = true, [Optional] Matrix reference)
		{
		}

		// Token: 0x06005EFD RID: 24317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA6")]
		[Address(RVA = "0x2C30FD0", Offset = "0x2C310D1", VA = "0x2C30FD0")]
		public static void BlendLayers(Matrix[] matrices, float[] opacity)
		{
		}

		// Token: 0x06005EFE RID: 24318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA7")]
		[Address(RVA = "0x2C311A0", Offset = "0x2C312A1", VA = "0x2C311A0")]
		public static void NormalizeLayers(Matrix[] matrices, float[] opacity)
		{
		}

		// Token: 0x06005EFF RID: 24319 RVA: 0x0001FA10 File Offset: 0x0001DC10
		[Token(Token = "0x6004EA8")]
		[Address(RVA = "0x2C2C630", Offset = "0x2C2C731", VA = "0x2C2C630")]
		public float Fallof(int x, int z, float fallof)
		{
			return 0f;
		}

		// Token: 0x06005F00 RID: 24320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA9")]
		[Address(RVA = "0x2C23200", Offset = "0x2C23301", VA = "0x2C23200")]
		public void FillEmpty()
		{
		}

		// Token: 0x06005F01 RID: 24321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EAA")]
		[Address(RVA = "0x2C31340", Offset = "0x2C31441", VA = "0x2C31340")]
		public static void Blend(Matrix src, Matrix dst, float factor)
		{
		}

		// Token: 0x06005F02 RID: 24322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EAB")]
		[Address(RVA = "0x2C31480", Offset = "0x2C31581", VA = "0x2C31480")]
		public static void Mask(Matrix src, Matrix dst, Matrix mask)
		{
		}

		// Token: 0x06005F03 RID: 24323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EAC")]
		[Address(RVA = "0x2C316F0", Offset = "0x2C317F1", VA = "0x2C316F0")]
		public static void SafeBorders(Matrix src, Matrix dst, int safeBorders)
		{
		}

		// Token: 0x06005F04 RID: 24324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EAD")]
		[Address(RVA = "0x2C31990", Offset = "0x2C31A91", VA = "0x2C31990")]
		public void Add(Matrix add)
		{
		}

		// Token: 0x06005F05 RID: 24325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EAE")]
		[Address(RVA = "0x2C31A30", Offset = "0x2C31B31", VA = "0x2C31A30")]
		public void Add(Matrix add, Matrix mask)
		{
		}

		// Token: 0x06005F06 RID: 24326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EAF")]
		[Address(RVA = "0x2C31B10", Offset = "0x2C31C11", VA = "0x2C31B10")]
		public void Add(float add)
		{
		}

		// Token: 0x06005F07 RID: 24327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EB0")]
		[Address(RVA = "0x2C24620", Offset = "0x2C24721", VA = "0x2C24620")]
		public void Subtract(Matrix m)
		{
		}

		// Token: 0x06005F08 RID: 24328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EB1")]
		[Address(RVA = "0x2C31B80", Offset = "0x2C31C81", VA = "0x2C31B80")]
		public void InvSubtract(Matrix m)
		{
		}

		// Token: 0x06005F09 RID: 24329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EB2")]
		[Address(RVA = "0x2C31C10", Offset = "0x2C31D11", VA = "0x2C31C10")]
		public void ClampSubtract(Matrix m)
		{
		}

		// Token: 0x06005F0A RID: 24330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EB3")]
		[Address(RVA = "0x2C31D30", Offset = "0x2C31E31", VA = "0x2C31D30")]
		public void Multiply(Matrix m)
		{
		}

		// Token: 0x06005F0B RID: 24331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EB4")]
		[Address(RVA = "0x2C23480", Offset = "0x2C23581", VA = "0x2C23480")]
		public void Multiply(float m)
		{
		}

		// Token: 0x06005F0C RID: 24332 RVA: 0x0001FA28 File Offset: 0x0001DC28
		[Token(Token = "0x6004EB5")]
		[Address(RVA = "0x2C31DD0", Offset = "0x2C31ED1", VA = "0x2C31DD0")]
		public bool CheckRange(float min, float max)
		{
			return default(bool);
		}

		// Token: 0x06005F0D RID: 24333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EB6")]
		[Address(RVA = "0x2C31E50", Offset = "0x2C31F51", VA = "0x2C31E50")]
		public void Invert()
		{
		}

		// Token: 0x06005F0E RID: 24334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EB7")]
		[Address(RVA = "0x2C31EC0", Offset = "0x2C31FC1", VA = "0x2C31EC0")]
		public void InvertOne()
		{
		}

		// Token: 0x06005F0F RID: 24335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EB8")]
		[Address(RVA = "0x2C31F30", Offset = "0x2C32031", VA = "0x2C31F30")]
		public void Clamp01()
		{
		}

		// Token: 0x02000E2D RID: 3629
		[Token(Token = "0x2001450")]
		public class Stacker
		{
			// Token: 0x06005F10 RID: 24336 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B06")]
			[Address(RVA = "0x1DABF70", Offset = "0x1DAC071", VA = "0x1DABF70")]
			public Stacker(CoordRect smallRect, CoordRect bigRect)
			{
			}

			// Token: 0x17000C6C RID: 3180
			// (get) Token: 0x06005F11 RID: 24337 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E6C")]
			public Matrix matrix
			{
				[Token(Token = "0x6007B07")]
				[Address(RVA = "0x1DAC0E0", Offset = "0x1DAC1E1", VA = "0x1DAC0E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005F12 RID: 24338 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B08")]
			[Address(RVA = "0x1DAC100", Offset = "0x1DAC201", VA = "0x1DAC100")]
			public void ToSmall()
			{
			}

			// Token: 0x06005F13 RID: 24339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B09")]
			[Address(RVA = "0x1DAC1F0", Offset = "0x1DAC2F1", VA = "0x1DAC1F0")]
			public void ToBig()
			{
			}

			// Token: 0x0400BE8A RID: 48778
			[Token(Token = "0x401BBEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CoordRect smallRect;

			// Token: 0x0400BE8B RID: 48779
			[Token(Token = "0x401BBF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CoordRect bigRect;

			// Token: 0x0400BE8C RID: 48780
			[Token(Token = "0x401BBF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool preserveDetail;

			// Token: 0x0400BE8D RID: 48781
			[Token(Token = "0x401BBF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Matrix downscaled;

			// Token: 0x0400BE8E RID: 48782
			[Token(Token = "0x401BBF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Matrix upscaled;

			// Token: 0x0400BE8F RID: 48783
			[Token(Token = "0x401BBF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Matrix difference;

			// Token: 0x0400BE90 RID: 48784
			[Token(Token = "0x401BBF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private bool isDownscaled;
		}
	}
}

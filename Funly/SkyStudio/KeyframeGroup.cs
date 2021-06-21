using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000DDE RID: 3550
	[Token(Token = "0x200090A")]
	[Serializable]
	public class KeyframeGroup<T> : IKeyframeGroup where T : IBaseKeyframe
	{
		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06005BA9 RID: 23465 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005BAA RID: 23466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700091C")]
		public string name
		{
			[Token(Token = "0x6004BC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004BC5")]
			set
			{
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06005BAB RID: 23467 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005BAC RID: 23468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700091D")]
		public string id
		{
			[Token(Token = "0x6004BC6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004BC7")]
			set
			{
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06005BAD RID: 23469 RVA: 0x0001E1C8 File Offset: 0x0001C3C8
		// (set) Token: 0x06005BAE RID: 23470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700091E")]
		public int propertyId
		{
			[Token(Token = "0x6004BC8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ABD20", Offset = "0x1ABE21")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004BC9")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ABD30", Offset = "0x1ABE31")]
			set
			{
			}
		}

		// Token: 0x06005BAF RID: 23471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCA")]
		public KeyframeGroup(string name)
		{
		}

		// Token: 0x06005BB0 RID: 23472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCB")]
		public void AddKeyFrame(T keyFrame)
		{
		}

		// Token: 0x06005BB1 RID: 23473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCC")]
		public void RemoveKeyFrame(T keyFrame)
		{
		}

		// Token: 0x06005BB2 RID: 23474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCD")]
		public void RemoveKeyFrame(IBaseKeyframe keyframe)
		{
		}

		// Token: 0x06005BB3 RID: 23475 RVA: 0x0001E1E0 File Offset: 0x0001C3E0
		[Token(Token = "0x6004BCE")]
		public int GetKeyFrameCount()
		{
			return 0;
		}

		// Token: 0x06005BB4 RID: 23476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BCF")]
		public T GetKeyframe(int index)
		{
			return null;
		}

		// Token: 0x06005BB5 RID: 23477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD0")]
		public void SortKeyframes()
		{
		}

		// Token: 0x06005BB6 RID: 23478 RVA: 0x0001E1F8 File Offset: 0x0001C3F8
		[Token(Token = "0x6004BD1")]
		public float CurveAdjustedBlendingTime(InterpolationCurve curve, float t)
		{
			return 0f;
		}

		// Token: 0x06005BB7 RID: 23479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD2")]
		public T GetPreviousKeyFrame(float time)
		{
			return null;
		}

		// Token: 0x06005BB8 RID: 23480 RVA: 0x0001E210 File Offset: 0x0001C410
		[Token(Token = "0x6004BD3")]
		public bool GetSurroundingKeyFrames(float time, out T beforeKeyframe, out T afterKeyframe)
		{
			return default(bool);
		}

		// Token: 0x06005BB9 RID: 23481 RVA: 0x0001E228 File Offset: 0x0001C428
		[Token(Token = "0x6004BD4")]
		public bool GetSurroundingKeyFrames(float time, out int beforeIndex, out int afterIndex)
		{
			return default(bool);
		}

		// Token: 0x06005BBA RID: 23482 RVA: 0x0001E240 File Offset: 0x0001C440
		[Token(Token = "0x6004BD5")]
		public static float ProgressBetweenSurroundingKeyframes(float time, BaseKeyframe beforeKey, BaseKeyframe afterKey)
		{
			return 0f;
		}

		// Token: 0x06005BBB RID: 23483 RVA: 0x0001E258 File Offset: 0x0001C458
		[Token(Token = "0x6004BD6")]
		public static float ProgressBetweenSurroundingKeyframes(float time, float beforeKeyTime, float afterKeyTime)
		{
			return 0f;
		}

		// Token: 0x06005BBC RID: 23484 RVA: 0x0001E270 File Offset: 0x0001C470
		[Token(Token = "0x6004BD7")]
		public static float WidthBetweenCircularValues(float begin, float end)
		{
			return 0f;
		}

		// Token: 0x06005BBD RID: 23485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD8")]
		public void TrimToSingleKeyframe()
		{
		}

		// Token: 0x06005BBE RID: 23486 RVA: 0x0001E288 File Offset: 0x0001C488
		[Token(Token = "0x6004BD9")]
		public InterpolationDirection GetShortestInterpolationDirection(float previousKeyValue, float nextKeyValue, float minValue, float maxValue)
		{
			return InterpolationDirection.Auto;
		}

		// Token: 0x06005BBF RID: 23487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BDA")]
		public void CalculateCircularDistances(float previousKeyValue, float nextKeyValue, float minValue, float maxValue, out float forwardDistance, out float reverseDistance)
		{
		}

		// Token: 0x06005BC0 RID: 23488 RVA: 0x0001E2A0 File Offset: 0x0001C4A0
		[Token(Token = "0x6004BDB")]
		public float InterpolateFloat(InterpolationCurve curve, InterpolationDirection direction, float time, float beforeTime, float nextTime, float previousKeyValue, float nextKeyValue, float minValue, float maxValue)
		{
			return 0f;
		}

		// Token: 0x06005BC1 RID: 23489 RVA: 0x0001E2B8 File Offset: 0x0001C4B8
		[Token(Token = "0x6004BDC")]
		public float AutoInterpolation(float curvedTime, float previousValue, float nextValue)
		{
			return 0f;
		}

		// Token: 0x06005BC2 RID: 23490 RVA: 0x0001E2D0 File Offset: 0x0001C4D0
		[Token(Token = "0x6004BDD")]
		public float ForwardInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance)
		{
			return 0f;
		}

		// Token: 0x06005BC3 RID: 23491 RVA: 0x0001E2E8 File Offset: 0x0001C4E8
		[Token(Token = "0x6004BDE")]
		public float ReverseInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance)
		{
			return 0f;
		}

		// Token: 0x0400BB21 RID: 47905
		[Token(Token = "0x4008BA0")]
		[FieldOffset(Offset = "0x0")]
		public List<T> keyframes;

		// Token: 0x0400BB22 RID: 47906
		[Token(Token = "0x4008BA1")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private string m_Name;

		// Token: 0x0400BB23 RID: 47907
		[Token(Token = "0x4008BA2")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private string m_Id;

		// Token: 0x0400BB24 RID: 47908
		[Token(Token = "0x4008BA3")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17D0F0", Offset = "0x17D1F1")]
		private int <propertyId>k__BackingField;
	}
}

using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace Tantawowa.TimelineEvents
{
	// Token: 0x020010E9 RID: 4329
	[Token(Token = "0x2000ADF")]
	public class EventInvocationInfo
	{
		// Token: 0x06006DB2 RID: 28082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AFD")]
		[Address(RVA = "0x1FC12C0", Offset = "0x1FC13C1", VA = "0x1FC12C0")]
		public EventInvocationInfo(string key, Behaviour targetBehaviour, MethodInfo methodInfo)
		{
		}

		// Token: 0x06006DB3 RID: 28083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AFE")]
		[Address(RVA = "0x1FC1330", Offset = "0x1FC1431", VA = "0x1FC1330")]
		public void Invoke(object value)
		{
		}

		// Token: 0x06006DB4 RID: 28084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AFF")]
		[Address(RVA = "0x1FC1420", Offset = "0x1FC1521", VA = "0x1FC1420")]
		public void InvokEnum(int value)
		{
		}

		// Token: 0x06006DB5 RID: 28085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B00")]
		[Address(RVA = "0x1FC1580", Offset = "0x1FC1681", VA = "0x1FC1580")]
		public void InvokeNoArgs()
		{
		}

		// Token: 0x06006DB6 RID: 28086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B01")]
		[Address(RVA = "0x1FC15E0", Offset = "0x1FC16E1", VA = "0x1FC15E0")]
		public void Invoke(bool isSingleArg, string value)
		{
		}

		// Token: 0x0401754F RID: 95567
		[Token(Token = "0x4014031")]
		[FieldOffset(Offset = "0x10")]
		public Behaviour TargetBehaviour;

		// Token: 0x04017550 RID: 95568
		[Token(Token = "0x4014032")]
		[FieldOffset(Offset = "0x18")]
		public MethodInfo MethodInfo;

		// Token: 0x04017551 RID: 95569
		[Token(Token = "0x4014033")]
		[FieldOffset(Offset = "0x0")]
		public static Type[] SupportedTypes;

		// Token: 0x04017552 RID: 95570
		[Token(Token = "0x4014034")]
		[FieldOffset(Offset = "0x20")]
		public string Key;
	}
}

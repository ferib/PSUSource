﻿using System;

namespace Obfuscator.Bytecode.IR
{
	public enum OpCode
	{
		OpMove,
		OpLoadK,
		OpLoadBool,
		OpLoadNil,
		OpGetUpValue,
		OpGetGlobal,
		OpGetTable,
		OpSetGlobal,
		OpSetUpValue,
		OpSetTable,
		OpNewTable,
		OpSelf,
		OpAdd,
		OpSub,
		OpMul,
		OpDiv,
		OpMod,
		OpPow,
		OpUnm,
		OpNot,
		OpLen,
		OpConcat,
		OpJump,
		OpEq,
		OpLt,
		OpLe,
		OpTest,
		OpTestSet,
		OpCall,
		OpTailCall,
		OpReturn,
		OpForLoop,
		OpForPrep,
		OpTForLoop,
		OpSetList,
		OpClose,
		OpClosure,
		OpVarArg,
		None,
		Custom,
		OpGetStack,
		OpNewStack,
		OpLoadJump,
		OpDynamicJump
	}
}

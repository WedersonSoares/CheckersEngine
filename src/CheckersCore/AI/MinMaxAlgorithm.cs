//int MaxMove(TreeNode currNode, int depth, List<TreeNode> pathNodes)
//{
//    if (depth == 0)
//    {
//        return StaticEvaluationFunction(currNode, depth);
//    }
//    else
//    {
//        depth--;
//        int v = -10000;
//        List<TreeNode> allPossRedMoveNodes = gameBoardScript.createNewRedBoardsFromCurrent(currNode.getCurrentBoard());
//        TreeNode bestNode = null;
//        foreach (TreeNode RedNode in allPossRedMoveNodes)
//        {
//            int v1 = MinMove(RedNode, depth, pathNodes);
//            if (v1 > v)
//            {
//                v = v1;
//                bestNode = RedNode;
//            }
//            //if the heuristic is equal then add the board piece values to the current heuristic ( I AM NOT SURE IF THIS IS CORRECT )
//            else if (v1 == v)
//            {
//                v1 += RedNode.getBoardMove().getMovedToPiece().getTieBreakerValue();
//                v = v1;
//            }
//        }
//        return v;
//    }
//}

//int MinMove(TreeNode currNode, int depth, List<TreeNode> pathNodes)
//{
//    if (depth == 0)
//    {
//        return StaticEvaluationFunction(currNode, depth);
//    }
//    else
//    {
//        depth--;
//        int v = 10000;
//        List<TreeNode> allPossBlackMoveNodes = gameBoardScript.createNewBlackBoardsFromCurrent(currNode.getCurrentBoard());
//        TreeNode bestNode = null;
//        foreach (TreeNode BlackNode in allPossBlackMoveNodes)
//        {
//            int v1 = MaxMove(BlackNode, depth, pathNodes);
//            if (v1 < v)
//            {
//                v = v1;
//                bestNode = BlackNode;
//            }
//            //when priorities are equal
//            else if (v1 == v)
//            {
//                v1 += BlackNode.getBoardMove().getMovedToPiece().getTieBreakerValue();
//                v = v1;
//            }
//        }
//        return v;
//    }
//}

//private int StaticEvaluationFunction(TreeNode node, int depth)
//{
//    return node.getHeuristic(); // Black - Red count at the last depth
//}
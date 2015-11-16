using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonPolynomial
{
    public class Newton
    {
        List<double> resultList = new List<double>();

        public List<double> count(List<Node> nodesList, int nodesCount)
        {
            //Zgodnie z zalozeniem Y-ki mialy sie znalezc w liscie wynikow
            for (int i = 0; i < nodesList.Count; i++)
            {
                resultList.Add(nodesList[i].Y);
            }

            int index1 = 1, index2 = 0;

            for (int i = 0; i < nodesCount - 1; i++)		                                    //ilosc krokow (poziomow) to n-1
            {
                for (int j = 0; j < nodesCount - 1 - i; j++)	                                //na kazdym poziomie bedzie n-i wynikow
                {
                    if (j + i + 1 > nodesCount - 1 || i + j + index1 > resultList.Count - 1)	//blokada dla ostatniego poziomu (wykona sie tylko jedna operacja)
                        return resultList;

                    double denominator1 = nodesList[j + i + 1].X;
                    double denominator2 = nodesList[j].X;

                    double nominator1 = resultList[i + j + index1];
                    double nominator2 = resultList[i + j + index2];

                    resultList.Add((nominator1 - nominator2) / (denominator1 - denominator2));
                }

                int increaseIndex = nodesCount - (i + 1);

                index1 += increaseIndex;
                index2 += increaseIndex;
            }

            return null;

        }
    }
}

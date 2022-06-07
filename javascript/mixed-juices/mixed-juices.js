// @ts-check
//
// The line above enables type checking for this file. Various IDEs interpret
// the @ts-check directive. It will give you helpful autocompletion when
// implementing this exercise.

/**
 * Determines how long it takes to prepare a certain juice.
 *
 * @param {string} name
 * @returns {number} time in minutes
 */
export function timeToMixJuice(name) {
  switch (name) {
    case 'Pure Strawberry Joy':
      return .5
    case 'Energizer':
    case 'Green Garden':
      return 1.5;
    case 'Tropical Island':
      return 3;
    case 'All or Nothing':
      return 5;
    default:
      return 2.5;
  }
}

/**
 * Calculates the number of limes that need to be cut
 * to reach a certain supply.
 *
 * @param {number} wedgesNeeded
 * @param {string[]} limes
 * @returns {number} number of limes cut
 */
function numberOfWedges(size){
  switch(size){
  case 'small':
    return 6;
  case 'medium':
    return 8;
  case 'large':
    return 10
  }
}

export function limesToCut(wedgesNeeded, limes) {
  let count =0;
  while(wedgesNeeded>0 && limes.length>0){
    wedgesNeeded -= numberOfWedges(limes[0])
    limes.shift()
    count++
  }
return count

  }
    






/**
 * Determines which juices still need to be prepared after the end of the shift.
 *
 * @param {number} timeLeft
 * @param {string[]} orders
 * @returns {string[]} remaining orders after the time is up
 */
export function remainingOrders(timeLeft, orders) {
  do{console.log("new loop")
    console.log(orders)
    console.log("Time left", timeLeft)
    console.log("Time to make item: ", timeToMixJuice(orders[0]))
    timeLeft-=timeToMixJuice(orders[0])
    console.log("Time left", timeLeft)
    orders.shift()
    console.log("new list after removing:", orders)} while (timeLeft > 0)
  return orders
}

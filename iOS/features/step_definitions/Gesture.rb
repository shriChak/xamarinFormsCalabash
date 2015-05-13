Then (/^I swipe left on "([^\"]*)"$/) do |mark|
  swipe('left', {:query => "view marked:'#{mark}'"})
  sleep(STEP_PAUSE)
end

Then (/^I swipe (left|right|up|down) on number (\d+) at x (\d+) and y (\d+)$/) do |dir, index, x, y|
  index = index.to_i
  screenshot_and_raise "Index should be positive (was: #{index})" if (index<=0)
  swipe(dir, {:offset => {:x => x.to_i, :y => y.to_i}, :query => "scrollView index:#{index-1}"})
  sleep(STEP_PAUSE)
end
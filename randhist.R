args <- commandArgs(trailingOnly = TRUE)
plotname <- args[[1]]
plotvals <- as.integer(args[[2]])

x <- sample(0:plotvals, 1000, replace = TRUE)   
png(file="D:/RPlots/randhist.png", width=600, height=350)
hist(x, col="gold",main = paste("Histogram of", plotname))
dev.off()
